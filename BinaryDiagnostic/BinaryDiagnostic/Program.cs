const string inputFilePath = "./input.txt";

if (!File.Exists(inputFilePath))
{
    throw new Exception($"{inputFilePath} is not exist!");
}

var readText = File.ReadAllText(inputFilePath);

var splitReadText = readText.Split('\n').ToList();

var zeroCount = new int[12];

var oneCount = new int[12];

var binaryMax = string.Empty;
var binaryMin = string.Empty;

foreach (var line in splitReadText)
{
    for (var i = 0; i < line.Length; i++)
    {
        if (line[i] == '0')
        {
            zeroCount[i]++;
        }
        if (line[i] == '1')
        {
            oneCount[i]++;
        }
    }
}

for (var i = 0; i < zeroCount.Length; i++)
{
    binaryMax += zeroCount[i] >= oneCount[i] ? "0" : "1";
}

binaryMin = binaryMax.Aggregate(binaryMin, (current, ch)
    => current + (ch == '0' ? "1" : "0"));

var integerMin = Convert.ToInt32(binaryMin, 2);
var integerMax = Convert.ToInt32(binaryMax, 2);

var result = integerMin * integerMax;

Console.WriteLine($"Result: {result}");
