using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Book book = new Book(1,"Hello world", "2024", "Roan");
Magazine magazine = new Magazine(2, "dag allemaal", "2024", 15581);
DVD dvd = new DVD(3,"cars", "2006", 180);

List<LibraryItem> list = new List<LibraryItem>();

list.Add(book);
list.Add(magazine);
list.Add(dvd);

foreach(LibraryItem item in list){
    item.PrintDetails();
}


