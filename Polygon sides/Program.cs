using System;

namespace PolygonSides
{
    class PolygonSides
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPress (0) to see all polygon sides\n");
            Console.WriteLine("Press (1) to see the polygon sides list from 1 to 10");
            Console.WriteLine("Press (2) to see the polygon sides list from 1 to 20");
            Console.WriteLine("Press (3) to see the polygon sides list from 1 to 30");
            Console.WriteLine("Press (4) to see the polygon sides list from 1 to 40");
            Console.WriteLine("Press (5) to see the polygon sides list from 1 to 50");
            Console.WriteLine("Press (6) to see the polygon sides list from 1 to 60");
            Console.WriteLine("Press (7) to see the polygon sides list from 1 to 70");
            Console.WriteLine("Press (8) to see the polygon sides list from 1 to 80");
            Console.WriteLine("Press (9) to see the polygon sides list from 1 to 90");
            Console.WriteLine("Press (10) to see the polygon sides list from 1 to 100");

            while (true)
            {
                Console.Write("\nEnter your choice: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int userChoice)) // Controleert of de invoer een geldig geheel getal is en slaat het resultaat op in userChoice
                {
                    switch (userChoice)
                    {
                        case 0:
                            PrintPolygonSides(1, 100);
                            break;
                        case 1:
                            PrintPolygonSides(1, 10);
                            break;
                        case 2:
                            PrintPolygonSides(11, 20);
                            break;
                        case 3:
                            PrintPolygonSides(21, 30);
                            break;
                        case 4:
                            PrintPolygonSides(31, 40);
                            break;
                        case 5:
                            PrintPolygonSides(41, 50);
                            break;
                        case 6:
                            PrintPolygonSides(51, 60);
                            break;
                        case 7:
                            PrintPolygonSides(61, 70);
                            break;
                        case 8:
                            PrintPolygonSides(71, 80);
                            break;
                        case 9:
                            PrintPolygonSides(81, 90);
                            break;
                        case 10:
                            PrintPolygonSides(91, 100);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");  //kan alleen 0 tot en ment 10 zijn
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input"); //kan niks anders dan een getal zijn
                }
            }
        }

        static void PrintPolygonSides(int start, int end)
        {
            string[] polygonNames = {
                "Henagon (1 side)", "Digon (2 sides)", "Trigon (3 sides)", "Tetragon (4 sides)", "Pentagon (5 sides)",
                "Hexagon (6 sides)", "Heptagon (7 sides)", "Octagon (8 sides)", "Enneagon (9 sides)", "Decagon (10 sides)",
                "Hendecagon (11 sides)", "Dodecagon (12 sides)", "Triskaidecagon (13 sides)", "Tetrakaidecagon (14 sides)",
                "Pentadecagon (15 sides)", "Hexakaidecagon (16 sides)", "Heptadecagon (17 sides)", "Octakaidecagon (18 sides)",
                "Enneadecagon (19 sides)", "Icosagon (20 sides)", "Icosihenagon (21 sides)", "Icosidigon (22 sides)",
                "Icositrigon (23 sides)", "Icositetragon (24 sides)", "Icosipentagon (25 sides)", "Icosihexagon (26 sides)",
                "Icosiheptagon (27 sides)", "Icosioctagon (28 sides)", "Icosienneagon (29 sides)", "Triacontagon (30 sides)",
                "Triacontahenagon (31 sides)", "Triacontadigon (32 sides)", "Triacontatrigon (33 sides)", "Triacontatetragon (34 sides)",
                "Triacontapentagon (35 sides)", "Triacontahexagon (36 sides)", "Triacontaheptagon (37 sides)", "Triacontaoctagon (38 sides)",
                "Triacontaenneagon (39 sides)", "Tetracontagon (40 sides)", "Tetracontahenagon (41 sides)", "Tetracontadigon (42 sides)",
                "Tetracontatrigon (43 sides)", "Tetracontatetragon (44 sides)", "Tetracontapentagon (45 sides)", "Tetracontahexagon (46 sides)",
                "Tetracontaheptagon (47 sides)", "Tetracontaoctagon (48 sides)", "Tetracontaenneagon (49 sides)", "Pentacontagon (50 sides)",
                "Pentacontahenagon (51 sides)", "Pentacontadigon (52 sides)", "Pentacontatrigon (53 sides)", "Pentacontatetragon (54 sides)",
                "Pentacontapentagon (55 sides)", "Pentacontahexagon (56 sides)", "Pentacontaheptagon (57 sides)", "Pentacontaoctagon (58 sides)",
                "Pentacontaenneagon (59 sides)", "Hexacontagon (60 sides)", "Hexacontahenagon (61 sides)", "Hexacontadigon (62 sides)",
                "Hexacontatrigon (63 sides)", "Hexacontatetragon (64 sides)", "Hexacontapentagon (65 sides)", "Hexacontahexagon (66 sides)",
                "Hexacontaheptagon (67 sides)", "Hexacontaoctagon (68 sides)", "Hexacontaenneagon (69 sides)", "Heptacontagon (70 sides)",
                "Heptacontahenagon (71 sides)", "Heptacontadigon (72 sides)", "Heptacontatrigon (73 sides)", "Heptacontatetragon (74 sides)",
                "Heptacontapentagon (75 sides)", "Heptacontahexagon (76 sides)", "Heptacontaheptagon (77 sides)", "Heptacontaoctagon (78 sides)",
                "Heptacontaenneagon (79 sides)", "Octacontagon (80 sides)", "Octacontahenagon (81 sides)", "Octacontadigon (82 sides)",
                "Octacontatrigon (83 sides)", "Octacontatetragon (84 sides)", "Octacontapentagon (85 sides)", "Octacontahexagon (86 sides)",
                "Octacontaheptagon (87 sides)", "Octacontaoctagon (88 sides)", "Octacontaenneagon (89 sides)", "Enneacontagon (90 sides)",
                "Enneacontahenagon (91 sides)", "Enneacontadigon (92 sides)", "Enneacontatrigon (93 sides)", "Enneacontatetragon (94 sides)",
                "Enneacontapentagon (95 sides)", "Enneacontahexagon (96 sides)", "Enneacontaheptagon (97 sides)", "Enneacontaoctagon (98 sides)",
                "Enneacontaenneagon (99 sides)", "Hectogon (100 sides)"
            };

            if (end > polygonNames.Length) end = polygonNames.Length; 

            for (int i = start - 1; i < end; i++) 
            {
                Console.WriteLine(polygonNames[i]); //print de items die we willen zien
            }
        }
    }
}
