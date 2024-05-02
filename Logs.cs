using System;
using System.IO;

public class Logs
{
   
    public string logFilePath = "D:\\Visual studio\\projets\\shalling-avancé\\MonFichierLog.log";
    public Logs(string logFilePath)
    {
        this.logFilePath = logFilePath;
    }
    public void WriteLog(string message)
    {
        try
        {
      
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
       
                sw.WriteLine($"{DateTime.Now:dd-MM-yyyy HH:mm:ss} - {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur lors de l'écriture dans le fichier log : {ex.Message}");
        }
    }
}

