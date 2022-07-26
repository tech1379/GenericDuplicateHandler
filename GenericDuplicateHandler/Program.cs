// See https://aka.ms/new-console-template for more information
using GenericDuplicateHandler;



//Input 1:
var handler = new DuplicateHandler<string>();
var newListString = new List<string>
     {
         "Hello",
         "World",
         "Hello",
         "Hello"
     };

var output = handler.RemoveDuplicates(newListString);

foreach(string c in output)
{
    Console.WriteLine(c);
}
Console.WriteLine("--------------------------------------------");
//Input 2:
var handler1 = new DuplicateHandler<int>();
var newListInt = new List<int>
     {
         1,2,3,4,5,1,2,3,3
     };

var output1 = handler1.RemoveDuplicates(newListInt);

foreach (int c in output1)
{
    Console.WriteLine(c);
}
Console.WriteLine("---------------------------------------------");
//Input 3:

var handler2 = new DuplicateHandler<Page>();
var newListObj = new List<Page>();
var newPage = new Page
{
    Id = 1,
    FileName = "TestFile.txt",
    DocumentType = "TestDocType",
    ImportDate = DateTime.Now,
    PageNumber = 1
};

newListObj.Add(newPage);
newListObj.Add(newPage);
newListObj.Add(newPage);

var output2 = handler2.RemoveDuplicates(newListObj);

foreach (Page c in output2)
{
    Console.WriteLine(c.Id + " " + c.FileName);
}

