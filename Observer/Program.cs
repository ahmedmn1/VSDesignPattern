// See https://aka.ms/new-console-template for more information
// Problem: we have an excel sheet with table record an another sheet contains total values of the first sheet and a pie chart that represent
// the data from sheet1.
// we need to notify the pie chart and the sheet2 when datachanges in sheet 1
using Observer.Push;
using Observer.Pull;


//Push Communication Style
ExcelSheet1 excelSheet1 = new();
ExcelSheet2 excelSheet2 = new();
PChart chart = new();
var datasource = new DataSource();
datasource.AddObserver(excelSheet1);
datasource.AddObserver(excelSheet2);
datasource.AddObserver(chart);
datasource.Value = 22;//Notify Observers


//Pull Communication Style
var dataSourceP= new DataSourceP();
ExcelSheet1P excelSheet1P = new(dataSourceP);
ExcelSheetP excelSheetP = new(dataSourceP);
PChartP pChartP = new(dataSourceP);
dataSourceP.AddObserver(excelSheetP);
dataSourceP.AddObserver(pChartP);
dataSourceP.AddObserver(excelSheet1P);
dataSourceP.CustomerSales = 23;
dataSourceP.CustomerName = "Mickey Mouse";



