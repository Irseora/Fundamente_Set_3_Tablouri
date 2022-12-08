using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rezolvari;

namespace Fundamente_Set_3_Tablouri
{
    class Program
    {
        /// <summary> Afiseaza indicatiile celor 31 probleme, apoi citeste si returneaza numarul problemei dorite. </summary>
        /// <param name="indicatii"> Indicatiile problemelor </param>
        /// <returns> Numarul problemei alese </returns>
        static int Afis(string[] indicatii)
        {
            Console.Clear();
            for (int i = 0; i < indicatii.Length; i++)
                Console.WriteLine($"{indicatii[i]}{Environment.NewLine}");
            
            int prob = 0;
            while (prob < 1)
            {
                Console.WriteLine($"{Environment.NewLine}Alegeti o problema: ");
                prob = int.Parse(Console.ReadLine());
            }

            return prob;
        }

        static void Main(string[] args)
        {
            // Indicatiile celui de al treilea set de probleme (31)
            string[] indicatii = {"Setul de probleme 3 (Tablouri):",
                                  $" 1. Calculati suma elementelor unui vector de n numere citite de la tastatura.{Environment.NewLine}",
                                  $" 2. Se da un vector cu n elemente si o valoare k.{Environment.NewLine}    Se cere sa se determine prima pozitie din vector pe care apare k.",
                                        // Daca k nu apare in vector rezultatul va fi -1.
                                  $" 3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.",
                                        // Pentru extra-credit realizati programul efectuand 3n / 2 comparatii (in cel mai rau caz).
                                  $" 4. Determinati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.",
                                  $" 5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k.{Environment.NewLine}    Se cere sa se insereze valoarea e in vector pe pozitia k.{Environment.NewLine}    Primul element al vectorului se considera pe pozitia 0.",
                                  $" 6. Se da un vector cu n elemente si o pozitie din vector k.{Environment.NewLine}    Se cere sa se stearga din vector elementul de pe pozitia k.",
                                        // Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
                                  $" 7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.",
                                        // Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
                                  $" 8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.",
                                        // Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
                                  $" 9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.",
                                  $"10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.{Environment.NewLine}    Se cere sa se determine pozitia unui element dat k.",
                                        // Daca elementul nu se gaseste in vector rezultatul va fi -1.
                                  $"11. Ciurul lui Eratostene. Se da un numar natural n.{Environment.NewLine}    Se cere sa se afiseze toate numerele prime mai mici sau egale cu n.",
                                  $"12. Implementati algoritmul de sortare Selection Sort.",
                                  $"13. Implementati algoritmul de sortare Insertion Sort.",
                                  $"14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.",
                                        // Nu se vor folosi vectori suplimentari
                                        // Operatia se va realiza inplace cu un algoritm eficient  
                                        // Se va face o singura parcugere a vectorului
                                  $"15. Modificati un vector prin eliminarea elementelor care se repeta.",
                                        // Nu se vor folosi vectori suplimentari
                                  $"16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.",
                                  $"17. Se da un numar n in baza 10 si un numar b (1 < b < 17). Sa se converteasca si sa se afiseze numarul n in baza b. ",
                                  $"18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Se cere valoarea polinomului intr-un punct x.",
                                        // Cel mai putin semnificativ coeficient este pe pozitia zero in vector.
                                  $"19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s.",
                                        // De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.  
                                        // Problema este dificila doar daca o rezolvati cu un algoritm liniar.
                                  $"20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.{Environment.NewLine}    Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.{Environment.NewLine}    Siragurile de margele se pot roti atunci cand le suprapunem. ",
                                  $"21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica.",
                                        // Care ar trebui sa apara primul in dictionar
                                  $"22. Implementarea operatiilor cu multimi. Se dau doi vectori v1 si v2.{Environment.NewLine}    Se cere sa determine intersectia, reuniunea, si diferentele v1 - v2 si v2 - v1.{Environment.NewLine}    Elementele care se repeta vor fi scrise o singura data in rezultat.",
                                  $"23. Se dau doi vectori v1 si v2 ordonati strict crescator.{Environment.NewLine}    Se cere sa determine intersectia, reuniunea, si diferentele v1 - v2 si v2 - v1.{Environment.NewLine}    Elementele care se repeta vor fi scrise o singura data in rezultat.",
                                  $"24. Se dau doi vectori v1 si v2 cu elemente stocate ca valori binare.{Environment.NewLine}    Se cere sa determine intersectia, reuniunea, si diferentele v1 - v2 si v2 - v1.{Environment.NewLine}    Elementele care se repeta vor fi scrise o singura data in rezultat.",
                                        // v[i] este 1 daca i face parte din multime si este 0 in caz contrar
                                  $"25. (Interclasare) Se dau doi vector sortati crescator v1 si v2.{Environment.NewLine}    Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.{Environment.NewLine}    Sunt permise elemente duplicate.",
                                  $"26. Se dau doua numere naturale foarte mari. Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.  ",
                                  $"27. Se da un vector si un index in vectorul respectiv.{Environment.NewLine}    Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.",
                                  $"28. Implementati algoritmul de sortare QuickSort.",
                                  $"29. Implementati algoritmul de sortare MergeSort.",
                                  $"30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W,{Environment.NewLine}    unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].{Environment.NewLine}    Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare,{Environment.NewLine} iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.",
                                  $"31. Element majoritate. Intr-un vector cu n elemente, un element m este element majoritate{Environment.NewLine}    daca mai mult de n/2 din valorile vectorului sunt egale cu m.{Environment.NewLine}    Sa se determine elementul majoritate al unui vector."
                                        // Prin urmare, daca un vector are element majoritate acesta este unul singur
                                        // Daca nu exista atunci se va afisa "nu exista"
                                        // Incercati sa gasiti o solutie liniara
                                  };

            // TODO: Citiri

            // Apeleaza functia care rezolva problema aleasa
            int prob = Afis(indicatii);
            switch (prob)
            {
                case  1:  break;
                case  2:  break;
                case  3:  break;
                case  4:  break;
                case  5:  break;
                case  6:  break;
                case  7:  break;
                case  8:  break;
                case  9:  break;
                case 10:  break;
                case 11:  break;
                case 12:  break;
                case 13:  break;
                case 14:  break;
                case 15:  break;
                case 16:  break;
                case 17:  break;
                case 18:  break;
                case 19:  break;
                case 20:  break;
                case 21:  break;
                case 22:  break;
                case 23:  break;
                case 24:  break;
                case 25:  break;
                case 26:  break;
                case 27:  break;
                case 28:  break;
                case 29:  break;
                case 30:  break;
                case 31:  break;
                
                default: break;
            }

            // TODO: Afisari
        }
    }
}