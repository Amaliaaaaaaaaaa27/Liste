//Listele sunt o structură de date utilă pentru stocarea și manipularea unui grup de obiecte de același tip. Ele oferă o flexibilitate mai mare decât alte structuri de date precum tablourile fixe, deoarece dimensiunea listelor poate fi modificată dinamic pe parcursul execuției programului. Iată câteva concepte importante
//despre lucrul cu liste în C#:

/*IMPORTAREA SPATIULUI DE NUME
Pentru a folosi listele în C#, trebuie să importezi spațiul de nume System.Collections.Generic în fișierul tău sursă:

  =>           using System.Collections.Generic;*/



/*DECLARAREA SI INITIALIZAREA UNEI LISTE
 
Pentru a declara și inițializa o listă, poți folosi sintaxa următoare:
csharp

  =================>List<TipElement> lista = new List<TipElement>();


Înlocuiește TipElement cu tipul de date pe care dorești să-l stochezi în listă. De exemplu, dacă dorești
să ai o listă de numere întregi, vei folosi int ca tip de element*/


/* 1 ADAUGAREA DE ELEMENTE INTR- O LISTA
Pentru a adăuga elemente într-o listă, poți utiliza metoda Add():

lista.Add(element); */

/* 2 ACCESAREA ELEMENTELOR DINTR  O LISTA :
 
Pentru a accesa elementele dintr-o listă, poți folosi operatorul de indexare []. 
Indicele începe de la zero pentru primul element din listă. De exemplu, pentru a accesa primul element al unei liste:

var primulElement = lista[0]; */

/*Numărul de elemente dintr-o listă:
Pentru a obține numărul de elemente dintr-o listă, poți utiliza proprietatea Count:






int numarElemente = lista.Count; */

// Add(T item): Adaugă un element la sfârșitul listei (1) x

// AddRange(IEnumerable<T> collection): Adaugă o colecție de elemente la sfârșitul listei(2 liste)
//===========>>>>>>>>>lista1.AddRange(lista2);


// Insert(int index, T item): Inserează un element la o anumită poziție în listă(1 lista)
// Inserăm elementul 15 la poziția index 1
//===========>>>>>>>lista.Insert(1, 15);


// InsertRange(int index, IEnumerable<T> collection): Inserează o colecție de elemente la o anumită poziție în listă
// Inserăm toate elementele din lista "elemente" la poziția index 2
//===========>>>>>>>>lista1.InsertRange(2, lista2); 

// Remove(T item): Șterge prima apariție a unui element din listă


// RemoveAt(int index): Șterge elementul de la o anumită poziție în listă  lista.Remove(3)


// RemoveRange(int index, int count): Șterge un număr specific de elemente începând de la o anumită poziție în listă    x

//===========>>>>>>>>> Numelista.RemoveRange(2, 3); // incepe de la indexul 2 si se elimina 3 elemente


// Contains(T item): Verifică dacă un element există în listă


// IndexOf(T item): Returnează indexul primei apariții a unui element în listă(mai precis arata indexul la care se afla elementul);
// 

// LastIndexOf(T item): Returnează indexul ultimei apariții a unui element în listă
// gasirea indexului unei valori

// ToArray(): Converteste lista într-un vector de elemente
//==============>>>> numeLista.ToArray()

// Sort(): Ordonează elementele listei în ordine crescătoare    x 
//==============>>>> numeLista.Sort()

// Reverse(): Inversează ordinea elementelor în listă
//==============>>>> numeLista.Reverse()

// Clear(): Șterge toate elementele din lista
//// ==============>>>> numeLista.Clear()

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scrieti cate numere sa contina lista == ");

        int numarCifre = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti numere in lista");

        List<int> lista1 = new List<int>(numarCifre);

        for (int i = 0; i < numarCifre; i++)
        {
            int cifre = int.Parse(Console.ReadLine());

            lista1.Add(cifre); // AM folosit Add pt a adauga numere
        }

        Console.WriteLine("Sortarea numerelor = ");
        lista1.Sort();  // Am folosit Sort pt a sorta numere
        foreach (int num in lista1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Vrem sa stergem de la idexul 1 trei pozitii");

        lista1.RemoveRange(1, 3); // INCEPE DE LA INDEXUL 1 SI SE STERG 3 ELEMENTE  // RemoveRange  

        foreach (int num in lista1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Dupa ce am sters cate elemente am dorit acum o sa inseram o noua colectie dupa indexul 2 a primei colectii");
        // creeam o noua lista care putem sa o adaugam in listaprincipala mai exact lista1

        Console.WriteLine("Tastati cate elemente o sa aiba a doua lista");

        int elemt2 = int.Parse(Console.ReadLine());


        List<int> lista2 = new List<int>(elemt2);

        Console.WriteLine("Introduce ti elementele in a doua lista == ");

        for (int i = 0; i < elemt2; i++)
        {
            int elementeLista2 = int.Parse(Console.ReadLine());

            lista2.Add(elementeLista2);
        }
        Console.WriteLine("Acestea sunt elementele a listei a doua ");
        foreach (int num in lista2)
        {
            Console.WriteLine(num);
        }
        // ADAUGAM NUMERELE DIN LISTA A DOUA IN LISTA INTAI FOLOSIND InsertRange()

        lista1.InsertRange(2, lista2); // de la indexul doi o sa inseram colectia (lista2) in lista1 formandu se o singura colectie 

        Console.WriteLine("Actualizarea listei 1 ");

        foreach (int num in lista1)
        {
            Console.WriteLine(num);
        }
        // Acum dorim sa folosim insert simplu 
        lista2.Insert(2, 3); // doresc sa inserez dupa indexul 2 nr 3 , puteam sa citim si de la tastatura 
        foreach (int num in lista1)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Acum o sa stergem lista 1 ");

        lista1.Clear();

        foreach (int num in lista1)
        {
            Console.WriteLine(num);
        }
        // FOLOSIM Contains(T item): Verifică dacă  o valoare exista  (nu un index)  există în listă
        Console.WriteLine("Acum verificam daca in lista a doua exista un element sau nu");

        int nrCautat = int.Parse(Console.ReadLine());

        if (lista2.Contains(nrCautat))
        {
            Console.WriteLine("Exista ");

        }
        else
        {
            Console.WriteLine("Nu exista");
        }



    }
}




