using System.Diagnostics;

string title = File.ReadAllText(Path.Combine("Data", "Configuration",
    "Console Title.cfg"));
Console.Title = title;

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
}