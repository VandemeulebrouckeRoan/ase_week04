Wine wine = new Wine("Chateau Margaux", 1787, 2250, 150, "France", WineType.Red);
PostStamp postStamp = new PostStamp("Penny Black", 1840, 1000, "pennyBlack.jpg");
ComicBook comicBook = new ComicBook("The Amazing spiderman", 1963, 1000, "Marvel", "Stan Lee");

List<object> collection = new List<object>();

collection.Add(wine);
collection.Add(postStamp);
collection.Add(comicBook);

foreach (object item in collection)
{
    Console.WriteLine(item);
}