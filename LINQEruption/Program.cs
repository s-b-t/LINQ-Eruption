List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// 1. Use LINQ to find the first eruption that is in Chile and print the result.

Eruption? firstEruptionInChile = eruptions.FirstOrDefault(l => l.Location == "Chile");
Console.WriteLine("==================================");
Console.WriteLine($"1. Here is the first Eruption in Chile: {firstEruptionInChile}");
Console.WriteLine("==================================");


// 2. Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstEruptionInHawaii = eruptions.FirstOrDefault(l => l.Location == "Hawaiian Is");

if(firstEruptionInHawaii == null) 
{
    Console.WriteLine("No Hawaiian Island volcanic activity found.");
}
else
{
    Console.WriteLine($"2. Here is the first eruption in the Hawaiian Islands: {firstEruptionInHawaii}");
    Console.WriteLine("==================================");
}


// 3. Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."

Eruption? firstEruptionInGreenland = eruptions.FirstOrDefault(l => l.Location == "Greenland");

if(firstEruptionInGreenland == null)
{
    Console.WriteLine("3. No Greenland volcanic activity found.");
    Console.WriteLine("==================================");
}
else
{
    Console.WriteLine(firstEruptionInGreenland);
}


// 4. Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.

Eruption? firstEruptionAfter1900InNewZealand = eruptions.Where(y => y.Year > 1900).FirstOrDefault(l => l.Location == "New Zealand");

Console.WriteLine($"4. Here is the first eruption after 1900 in New Zealand: {firstEruptionAfter1900InNewZealand}");
Console.WriteLine("==================================");


// 5. Find all eruptions where the volcano's elevation is over 2000m and print them.

IEnumerable<Eruption> elevationOver2000 = eruptions.Where(e => e.ElevationInMeters > 2000);

Console.WriteLine("5. Here are all the volcanoes higher than 2000m:");
PrintEach(elevationOver2000);
Console.WriteLine("==================================");


// 6. Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.

IEnumerable<Eruption> volcanoStartsWithL = eruptions.Where(v => v.Volcano.StartsWith("L"));

Console.WriteLine("6a. Volcano Names that start with 'L':");
PrintEach(volcanoStartsWithL);
Console.WriteLine($"6b. Number of Volcano Names that start with 'L': {volcanoStartsWithL.Count()}");
Console.WriteLine("==================================");


// 7. Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)

int highestElevation = eruptions.Max(e => e.ElevationInMeters);

Console.WriteLine($"7. Highest volcano elevation found: {highestElevation}m");
Console.WriteLine("==================================");


// 8. Use the highest elevation variable to find a print the name of the Volcano with that elevation.

Eruption? highestElevationVolcano = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestElevation);

Console.WriteLine($"8. Highest elevated volcano description: {highestElevationVolcano}");
Console.WriteLine("==================================");


// 9. Print all Volcano names alphabetically.

IEnumerable<Eruption> alphabetOrderedVolcanoes = eruptions.OrderBy(v => v.Volcano);

Console.WriteLine("9. Alphabetized Volcano names:");
PrintEach(alphabetOrderedVolcanoes);
Console.WriteLine("==================================");


// 10. Print the sum of all the elevations of the volcanoes combined.

int sumOfElevations = eruptions.Sum(e => e.ElevationInMeters);

Console.WriteLine($"10. Sum of all volcano elevations: {sumOfElevations}m");
Console.WriteLine("==================================");


// 11. Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)

bool eruptionsIn2000 = eruptions.Any(y => y.Year == 2000);

Console.WriteLine($"11. Have any volcanoes erupted in the year 2000?: {eruptionsIn2000}");
Console.WriteLine("==================================");


// 12. Find all stratovolcanoes and print just the first three (Hint: look up Take)

IEnumerable<Eruption> firstThreeStratoVolcanoes = eruptions.Where(t => t.Type == "Stratovolcano").Take(3);

Console.WriteLine("12. First three Stratovolcanoes:");
PrintEach(firstThreeStratoVolcanoes);
Console.WriteLine("==================================");


// 13. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.

IEnumerable<Eruption> eruptionsAlphabeticalBefore1000 = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano);

Console.WriteLine("13. Alphabetical list of Volcanoes before 1000 CE:");
PrintEach(eruptionsAlphabeticalBefore1000);
Console.WriteLine("==================================");


// 14. Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.

IEnumerable<Eruption> eruptionsAlphabeticalBefore1000Names = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano);

Console.WriteLine("14. Just the names from last query:");

foreach(Eruption e in eruptionsAlphabeticalBefore1000)
{
    Console.WriteLine(e.Volcano);
}

Console.WriteLine("==================================");











// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}


