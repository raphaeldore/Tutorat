﻿using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using TutoratAppl.Controller;

namespace TutoratAppl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* ##################### Section B ##################### */

            /* ---------- Section B1 ---------- */

            /* *Réinitialisation* et *Peuplement* des tables */
            Console.WriteLine("Initialisation des tables de la BD...");
            EfDataBaseHelper helper = new EfDataBaseHelper();
            helper.SeedDatabase();
            WaitForInput("Initialisation terminée. Appuyez sur une touche pour continuer...");

            /* On initialise les contrôleurs avec le bon type de dépôt */
            TutorController tutorController = new TutorController(new EfEntityRepository<Tutor>());
            HelpedStudentController helpStudentController = new HelpedStudentController(new EfEntityRepository<HelpedStudent>());
            TutoringSessionController tutoringSessionController = new TutoringSessionController(new EfEntityRepository<TutoringSession>());

            /* ---------- Section B2 ---------- */
            Console.WriteLine("###### Section B2 : Toutes les données des tables ######");

            WaitForInput("--- Liste de tous les Tutors ---");
            tutorController.ListAll();

            WaitForInput("--- Liste de tous les HelpedStudents ---");
            helpStudentController.ListAll();

            WaitForInput("--- Liste de tous les TutoringSessions ---");
            tutoringSessionController.ListAll();

            /* ##################### Section C ##################### */

            Console.WriteLine("###### Section C: Requêtes ######");
           
            Console.WriteLine("--- Requête No. 1 ---");
            Console.WriteLine("Liste de tous les tuteurs, avec le nombre total d'heures de tutorat (passé, présent, futur)\n");
            tutorController.ListAllWithWorkingHoursTotal();
            WaitForInput();

            Console.WriteLine("--- Requête No. 2 ---");
            Console.WriteLine("Liste des tuteurs qui ont des rencontres de planifiées dans le futur.\n"); //this is bugged
            tutoringSessionController.listAllFutureTutorTutoringSessions();
            WaitForInput();

            Console.WriteLine("--- Requête No. 3 ---");
            Console.WriteLine("Liste des étudiants aidées qui n'ont pas obtenu pour l'instant de rencontre avec un tuteur\n");
            helpStudentController.ListHelpStudentsWithoutTutoringSession();
            WaitForInput();

            Console.WriteLine("--- Requête No. 4 ---");
            Console.WriteLine("Liste des tuteurs qui n'ont aucune rencontre prévue le 2 Juin 2015\n");
            tutorController.listAllFreeTutorOnDate(new DateTime(2015, 6, 2, 0, 0, 0));
            WaitForInput();

            Console.WriteLine("C'est la fin!");
            WaitForInput("Appuyez sur une touche pour quitter...");
        }

        private static void WaitForInput(string messageToDisplay = "Appuyez sur une touche pour continuer...")
        {
            Console.WriteLine("\n" + messageToDisplay);
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}