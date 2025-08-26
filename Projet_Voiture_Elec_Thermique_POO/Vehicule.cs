using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Voiture_Elec_Thermique_POO
{
    abstract class Vehicule
    {

        protected string marque, modele, carburant;
        protected int annee;
        protected double? consommation, capaciteReservoir, capaciteBatterie, niveauCarburant, niveauBatterie;
        protected Vehicule(string marque, string modele, string carburant, int annee, double consommation, double capaciteReservoir, double capaciteBatterie, double niveauCarburant)
        {
            this.marque = marque;
            this.modele = modele;
            this.carburant = carburant;
            this.annee = annee;
            this.consommation = consommation;
            this.niveauCarburant = niveauCarburant;
            if (!this.carburant.Equals("electrqiue")) 
            {
                this.capaciteReservoir = capaciteReservoir;
                this.capaciteBatterie = null;
                this.niveauBatterie = null;
            }else 
            {
                this.capaciteBatterie = capaciteBatterie;
                this.capaciteReservoir = null;
                this.niveauCarburant = null;
            }
        }

        public virtual double GetAutonomie()
        {
            if (this.carburant.Equals("electrique"))
            {
                if (this.niveauBatterie.HasValue)
                {
                    return (double) (this.niveauBatterie.Value / this.consommation * 100);
                }
                else return 0;

            }
            else
            {
                if (this.niveauCarburant.HasValue)
                {
                    return (double) (this.niveauCarburant.Value / this.consommation * 100);
                }
                else return 0;
            }
        }


        public abstract void AfficherInfos();
        public abstract void CalculerCoutParKm();

        public abstract void Rouler(double kmAParcourir);

        public abstract void FairePleinOuRecharger(double Remplir);
    }
}
