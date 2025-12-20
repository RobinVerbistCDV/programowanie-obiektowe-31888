using Lab2;
using Newtonsoft.Json;

var path = Path.Combine(Directory.GetCurrentDirectory(), "Cars.json");
var txt =  File.ReadAllText(path);
var data = JsonConvert.DeserializeObject<List<Car>>(txt);

void AddCar()
{
    Console.WriteLine("INSERT CAR MODEL:");
    string model = Console.ReadLine();
    Console.WriteLine("INSERT CAR COLOR:");
    string color = Console.ReadLine();
    Console.WriteLine("INSERT CAR YEAR:");
    var success = int.TryParse(Console.ReadLine(), out  int year);

    if (!success || model == null || color == null)
    {
        Console.WriteLine("ERROR - WRONG DATA");
        return;
    }
    data.Add(new Car(model, year, color));
}

void RemoveCar()
{
    if (data.Count == 0)
    {
        Console.WriteLine("\nNO CARS IN DATABASE");
        return;
    }
    Console.WriteLine("INSERT INDEX OF THE CAR YOU WANT TO REMOVE:");
    var success = int.TryParse(Console.ReadLine(), out int index);
    if (!success || index < 0 || index >= data.Count)
    {
        Console.WriteLine("ERROR - WRONG INDEX");
        return;
    }
    data.RemoveAt(index);
}
void ChangeColor(){
    if (data.Count == 0)
    {
        Console.WriteLine("\nNO CARS IN DATABASE");
        return;
    }
    Console.WriteLine("INSERT INDEX OF THE CAR YOU WANT TO MODIFY THE COLOR:");
    var success = int.TryParse(Console.ReadLine(), out int index);
    if (!success || index < 0 || index >= data.Count)
    {
        Console.WriteLine("ERROR - WRONG INDEX");
        return;
    }
    Console.WriteLine("INSERT COLOR:");
    string color = Console.ReadLine();
    if (color == null)
    {
        Console.WriteLine("ERROR - WRONG DATA");
        return;
    }
    data[index].Color = color;
}

void ListCars()
{
    if (data.Count == 0)
    {
        Console.WriteLine("\nNO CARS IN DATABASE");
        return;
    }
    Console.WriteLine("LIST OF CARS:");
    for (int i = 0; i < data.Count; i++)
    {
        Console.WriteLine("ID: {0}", i);
        Console.WriteLine("MODEL: " + data[i].Model);
        Console.WriteLine("COLOR: " + data[i].Color);
        Console.WriteLine("YEAR: " + data[i].Year);
    }
}

do
{
    Console.WriteLine("MENU:");
    Console.WriteLine("1. ADD CAR");
    Console.WriteLine("2. REMOVE CAR");
    Console.WriteLine("3. MODIFY COLOR");
    Console.WriteLine("4. LIST CARS");
    Console.WriteLine("0. EXIT");
    var option = Console.ReadKey().KeyChar;
    Console.WriteLine();
    
    switch (option)
    {
        case '0':
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText(path, json);
            return;
        case '1':
            AddCar();
            break;
        case '2':
            RemoveCar();
            break;
        case '3':
            ChangeColor();
            break;
        case '4':
            ListCars();
            break;
    }
}while(true);