using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assigment3
{
    public class PacManagement
    {
        public PacManagement()
        {
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName).Dispose();              
            }
            ReadPacFromFileToList();
        }

        public int GetNextPacId()
        {
            if (_patient.Count == 0)
            {
                return 1;
            }
            else
            {
                var pacWithMaxId = _patient.MaxBy(a => a.PacId);
                return pacWithMaxId.PacId + 1;
            }
        }

        public List<Pac> GetAllPac()
        {
            return _patient;
        }

        public Pac? GetPacById(int pacId)
        {
            return _patient.Where(a => a.PacId == pacId).FirstOrDefault();
        }

        public void DeletePacById(int pac)
        {
            _patient.RemoveAll(a=>a.PacId==pac);
            WritePacToFile();
        }

        public void UpdatePac(Pac pac)
        {
            if (pac != null)
            {
                int pacIndex = _patient.FindIndex(a => a.PacId == pac.PacId);
                if (pacIndex != -1)
                {
                    _patient[pacIndex] = pac;
                    WritePacToFile();
                }
            }
        }
        public void AddPac(Pac pac)
        {            
            _patient.Add(pac);
            WritePacToFile();
        }
        

        private void WritePacToFile()
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                foreach (var pac in _patient)
                {
                    writer.WriteLine(WriteToFileRecord(pac));
                }
            }
        }

        private string WriteToFileRecord(Pac pac)
        {
            string cleanNote = Regex.Replace(pac.Note, @"\r\n?|\n", ";");

            return pac.PacId.ToString() + "|" + pac.PacName + "|" + pac.Birthday + "|" +
                    ((pac.Problem == null) ? "" + "|" : pac.Problem.ToString() + "|") + cleanNote;
        }

        private void ReadPacFromFileToList()
        {
            using (StreamReader reader = new StreamReader(_fileName))
            {
                _patient.Clear();

                while (!reader.EndOfStream)
                {
                    string? fileRecord = reader.ReadLine();
                    if (fileRecord != null)
                    {
                        Pac patient = ParsePacFromFileRecord(fileRecord);
                        _patient.Add(patient);
                    }
                }
            }
        }

        private Pac ParsePacFromFileRecord(string fileRecord) 
        {
            string[] pacFields = fileRecord.Split('|');
            return new Pac(Convert.ToInt32(pacFields[0]), pacFields[1], DateTime.Parse((pacFields[2])), pacFields[3], pacFields[4]);
        }
       
       

        private readonly string _fileName = @"patient.txt";
        private List<Pac> _patient = new List<Pac>();
    }
    
}
