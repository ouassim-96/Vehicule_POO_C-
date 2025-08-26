using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Voiture_Elec_Thermique_POO
{
    class VoitureThermique : Vehicule
    {
        private double prixEssence;

        public VoitureThermique(string marque, string modele, string carburant, int annee, double consommation, double capaciteReservoir, double capaciteBatterie, double niveauCarburant, double prixEssence) : base(marque, modele, carburant, annee, consommation, capaciteReservoir, capaciteBatterie, niveauCarburant)
        {
            this.prixEssence = prixEssence;
        }

        public override void AfficherInfos()
        {
            Console.WriteLine($"""
                marque : {this.marque} 
                modele : {this.modele}
                annee : {this.annee}
                capacite : {capaciteReservoir}
                """);
                
        }

        public override void CalculerCoutParKm()
        {
            throw new NotImplementedException();
        }

        public override void FairePleinOuRecharger(double NbrLitres)
        {
            if(this.niveauCarburant == capaciteReservoir) 
            {
                Console.WriteLine("vous avez déjà le plein");
            }
            else if (NbrLitres + this.niveauCarburant > this.capaciteReservoir) 
            {
                Console.WriteLine("vous pouvez pas mettre plus de carburant que ce que la capacité permet");
            }else 
            {
                this.niveauCarburant += NbrLitres;

            }
        }

        public override void Rouler(double kmAParcourir)
        {
            if(this.capaciteReservoir == 0) 
            {
                Console.WriteLine("le reservoir est vide");
            }

            if(this.GetAutonomie() > kmAParcourir) 
            {
                this.niveauCarburant -= kmAParcourir;
            }
        }


    }
}
