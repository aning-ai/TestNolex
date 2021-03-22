using System;
using System.Globalization;
using System.Reflection;
using IniParser;
using IniParser.Model;

namespace NolexIniSetting
{
    public static class IniSetting
    {
        public static bool Load(string fileini)
        {
            FileIniDataParser parser = new FileIniDataParser();
            parser.Parser.Configuration.CommentString = "#";

            IniData data = parser.ReadFile(fileini);
            foreach(var section in data.Sections)
            {
                string nomesezione = section.SectionName;
                string static_class_name = $"NolexIniSetting.Predefiniti_{nomesezione}";

                Type settingsType = Type.GetType(static_class_name);

                foreach (var prop in section.Keys)
                {
                    foreach (PropertyInfo propertyInformation in settingsType.GetProperties(BindingFlags.Public | BindingFlags.Static))
                    {
                        string name = prop.KeyName; 
                        if (propertyInformation.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            try
                            {
                                if (propertyInformation.CanWrite)
                                {
                                    propertyInformation.SetValue(settingsType, Convert.ChangeType(data[nomesezione][name], propertyInformation.PropertyType, CultureInfo.CurrentCulture), null);
                                    Console.WriteLine($"[{nomesezione}].[{name}] = {data[nomesezione][name]}");
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine($"[{nomesezione}].[{name}] = {e.Message}");
                                continue;
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }
    }
}
