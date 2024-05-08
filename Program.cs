using Prueba;

var vagones = new List<int>();
for(var i = 1; i < 10; i++)
{
    vagones.Add(i);
}

var tren = new Tren(vagones);


do
{
    tren.MostrarTren();

    Console.WriteLine("\n\n1 - Enganchar vagón");
    Console.WriteLine("2 - Desenganchar vagón");
    var option = Console.ReadLine();


    if (option == "1")
    {
        Console.WriteLine("Ingrese el número del vagón a agregar");
        var strVagon = Console.ReadLine();
        var vagon = int.Parse(strVagon);

        var enganche = "";
        do
        {
            Console.WriteLine("1 - Enganchar a la izquierda");
            Console.WriteLine("2 - Enganchar a la derecha");
            enganche = Console.ReadLine();

            if (enganche == "1")
            {
                tren.EngancharIzquierda(vagon);
            }
            else if (enganche == "2")
            {
                tren.EngancharDerecha(vagon);
            }

        } while(enganche != "1" && enganche != "2");


    }
    else if (option == "2")
    {
        var enganche = "";
        do
        {
            Console.WriteLine("1 - Desenganchar a la izquierda");
            Console.WriteLine("2 - Desenganchar a la derecha");
            enganche = Console.ReadLine();
            if (enganche == "1")
            {
                tren.DesengancharIzquierda();
            }
            else if (enganche == "2")
            {
                tren.DesengancharDerecha();
            }
        } while (enganche != "1" && enganche != "2");
    }
} while (true);
