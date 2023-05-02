using AljabarLibraries;

double[] APK = { 1, -3, -10 };
double[] HS = { 2, -3 };

double[] kecap = quadraticForm.akarKuadrat(APK);
double[] pelangi = quadraticForm.kuadrat(HS);

Console.WriteLine("{" + kecap[0] + ", " + kecap[1] + "}");
Console.WriteLine("{" + pelangi[0] + ", "+ pelangi[1] + ", " + pelangi[2] + "}");



