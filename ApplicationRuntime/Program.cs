using System.Diagnostics;
using System.IO;

string title = File.ReadAllText(Path.Combine("Data", "Configuration",
    "Console Title.cfg"));
Console.Title = title;

bool pause = Convert.ToBoolean(File.ReadAllText(Path.Combine("Data",
    "Configuration", "Pause.cfg")));

string runType = "CONSOLE";
Thread t = new Thread(StartCompiler);
t.Start();

void StartCompiler()
{
    Thread.Sleep(100);

    ProcessStartInfo psi = new ProcessStartInfo();

    if (runType == "CONSOLE")
        psi.FileName = Path.Combine(Directory.GetCurrentDirectory(),
            "Data", "Compiler", "Console", "HolyJava.exe");

    psi.WorkingDirectory = Directory.GetCurrentDirectory();
    Process.Start(psi);

    if (pause)
    {
        Console.ReadKey();
    }
}