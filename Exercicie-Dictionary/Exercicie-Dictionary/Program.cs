using Exercicie_Dictionary.Entities;
using System.IO;
using System.Xml.Linq;

namespace Exercicie_Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string, int> candidateVotes = new Dictionary<string, int>();

            Console.WriteLine("Enter the full path:");
            string url = Console.ReadLine();

            if (url == null)
            {
                Console.WriteLine("O arquivo pode estar vazio ou não existe");
            }
            else
            {

                try
                {
                    using (StreamReader sr = File.OpenText(url))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            if (line != null)
                            {
                                string[] votes = line.Split(",");
                                string name = votes[0];
                                int vote = int.Parse(votes[1]);
                                if (candidateVotes.ContainsKey(name))
                                {
                                    candidateVotes[name] += vote;
                                }
                                else
                                {
                                    candidateVotes[name] = vote;
                                }
                            }

                        }
                    }

                    List<Candidate> candidates = new List<Candidate>();

                    foreach (KeyValuePair<string, int> item in candidateVotes)
                    {
                        candidates.Add(new Candidate(item.Key, item.Value));
                    }
                    foreach (Candidate candidate in candidates)
                    {
                        Console.WriteLine($"{candidate.Name} : {candidate.Votes}");
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}