using System;
class Program
{
static void Main()
{
DocumentFactory wordFactory = new WordFactory();

wordFactory.CreateDocument().Open();

DocumentFactory pdfFactory = new PdfFactory();

pdfFactory.CreateDocument().Open();

DocumentFactory excelFactory = new ExcelFactory();

excelFactory.CreateDocument().Open();

}

}