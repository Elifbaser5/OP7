//OPERATION7

string[] codons = { "GCT", "GCC", "GCA", "GCG", "CGT", "CGC", "CGA", "CGG", "AGA", "AGG", "AAT", "AAC", "GAT", "GAC", "TGT", "TGC", "CAA", "CAG", "GAA", "GAG", "GGT", "GGC", "GGA", "GGG", "CAT", "CAC", "ATT", "ATC", "ATA", "CTT", "CTC", "CTA", "CTG", "TTA", "TTG", "AAA", "AAG", "ATG", "TTT", "TTC", "CCT", "CCC", "CCA", "CCG", "TCT", "TCC", "TCA", "TCG", "AGT", "AGC", "ACT", "ACC", "ACA", "ACG", "TGG", "TAT", "TAC", "GTT", "GTC", "GTA", "GTG", "TAA", "TGA", "TAG" };
string[] aminoacids = { "ala", "ala", "ala", "ala", "arg", "arg", "arg", "arg", "arg", "arg", "asn", "asn", "asp", "asp", "cys", "cys", "gln", "gln", "glu", "glu", "gly", "gly", "gly", "gly", "his", "his", "ile", "ile", "ile", "leu", "leu", "leu", "leu", "leu", "leu", "lys", "lys", "met", "phe", "phe", "pro", "pro", "pro", "pro", "ser", "ser", "ser", "ser", "ser", "ser", "thr", "thr", "thr", "thr", "trp", "tyr", "tyr", "val", "val", "val", "val", "stop", "stop", "stop" };
Console.WriteLine("please enter dna string");
string dnastring;

dnastring = Console.ReadLine();

for (int i = 0; i < codons.Length; i++)
{
    if (dnastring == codons[i])
        Console.WriteLine(aminoacids[i]);
}
Console.ReadLine();
