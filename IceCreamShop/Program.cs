using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;



// TODONE: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name' field.
availableFlavors.Sort(new FlavorComparer());

// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
availableCones.Sort(new ConeComparer());

// TODONE: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
Console.WriteLine(Environment.NewLine +"IceCream Menu" + Environment.NewLine);

Console.WriteLine("IceCream Flavors" + Environment.NewLine);
for(int i = 0; i < availableFlavors.Count; i++)
{
    Console.WriteLine(availableFlavors[i].Name);
}

Console.WriteLine(Environment.NewLine + "IceCream Cones" + Environment.NewLine);
for(int i = 0; i < availableCones.Count; i++)
{
    Console.WriteLine(availableCones[i].Name + " $" + availableCones[i].Cost);
}