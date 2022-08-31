// Как посмотреть содержимое папки?

string path = @"C:\Users\anyak\Desktop\Фронтенд-программист";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
