/****** Script per comando SelectTopNRows da SSMS  ******/
SELECT [Esami].id, 
		[Esami].descrizione,
		[Esami].codiceinterno,
		[Esami].codiceministeriale,
		[Ambulatori].descrizione,
		[PartiCorpo].descrizione
  FROM [TestNolex].[dbo].[Esami], [TestNolex].[dbo].[Ambulatori], [TestNolex].[dbo].[AmbulatoriEsami] , [TestNolex].[dbo].[PartiCorpo]
  where [Ambulatori].id = 7 
		and [PartiCorpo].Id=[Esami].idpartecorpo 
		and [TestNolex].[dbo].[AmbulatoriEsami].idambulatorio= [TestNolex].[dbo].[Ambulatori].id
		and [TestNolex].[dbo].[AmbulatoriEsami].idesame= [TestNolex].[dbo].[Esami].id