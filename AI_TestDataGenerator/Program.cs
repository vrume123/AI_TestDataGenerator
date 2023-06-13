using AI_TestDataGenerator;
using AI_TestDataGenerator.Builders;

var titlesFaker = TitlesFakerBuilder.Build();
var creditsFaker = CreditsFakerBuilder.Build();

var titles = titlesFaker.Generate(200);
var credits = creditsFaker.Generate(500);

var fileWriter = new CsvFileWriter(baseFilePath: "../../../");

fileWriter.WriteToFile(titles, "titles");
fileWriter.WriteToFile(credits, "credits");