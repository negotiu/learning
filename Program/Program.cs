// roses are {color}
// {plural} are blue
// i love {celebrity}

Console.WriteLine("roses are [color], \n[plurar noun] are blue, \ni love [celebrity]");
Thread.Sleep(1000);
Console.Write("input color: ");
string color = Console.ReadLine();
Console.Write("input plurar noun: ");
string noun = Console.ReadLine();
Console.Write("input celebrity: ");
string celeb = Console.ReadLine();

Thread.Sleep(2000);
Console.WriteLine("WAIT!");
Thread.Sleep(6000);

Console.WriteLine("Roses are " + color + ",\n" + noun + " are blue,\nI love " + celeb + ".") ;