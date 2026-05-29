using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;
using System.IO;

namespace PetApp
{
    public enum Trigger
    {
        Ate,
        Pet,
        TimePassed
    }

    public enum Mood
    {
        Happy,
        Hungry,
        Neutral,
        Sick
    }

    public enum Stage
    {
        Baby,
        Teen,
        Adult
    }
    public class Pet
    {
        private StateMachine<Mood, Trigger> _moodMachine;
        private StateMachine<Stage, Trigger> _stageMachine;

        public string Name { get; set; }
        public int AgeMinutes { get; set; }

        public Mood CurrentMood => _moodMachine.State;
        public Stage CurrentStage => _stageMachine.State;

        public Pet(string name)
        {
            Name = name;

            _moodMachine = new StateMachine<Mood, Trigger>(Mood.Neutral);
            _stageMachine = new StateMachine<Stage, Trigger>(Stage.Baby);
            ConfigureMachines();
            
        }
        public Pet(string name, int ageMinutes, Mood savedMood, Stage savedStage)
        {
            Name = name;
            AgeMinutes = ageMinutes;
            _moodMachine = new StateMachine<Mood, Trigger>(savedMood);
            _stageMachine = new StateMachine<Stage, Trigger>(savedStage);
            ConfigureMachines();
        }

        private void ConfigureMachines()
        {
            _moodMachine.Configure(Mood.Neutral)
                .Permit(Trigger.Ate, Mood.Happy)
                .Permit(Trigger.Pet, Mood.Happy)
                .Permit(Trigger.TimePassed, Mood.Hungry);

            _moodMachine.Configure(Mood.Happy)
                .PermitReentry(Trigger.Ate)
                .PermitReentry(Trigger.Pet)
                .Permit(Trigger.TimePassed, Mood.Neutral);

            _moodMachine.Configure(Mood.Hungry)
                .Permit(Trigger.Ate, Mood.Neutral)
                .PermitReentry(Trigger.Pet)
                .Permit(Trigger.TimePassed, Mood.Sick);

            _moodMachine.Configure(Mood.Sick)
                .Permit(Trigger.Ate, Mood.Neutral)
                .PermitReentry(Trigger.Pet)
                .PermitReentry(Trigger.TimePassed);

            _stageMachine.Configure(Stage.Baby)
                .Permit(Trigger.TimePassed, Stage.Teen);
            _stageMachine.Configure(Stage.Teen)
                .Permit(Trigger.TimePassed, Stage.Adult);
            _stageMachine.Configure(Stage.Adult)
                .Ignore(Trigger.TimePassed);
        }

        public void Feed()
        {
            _moodMachine.Fire(Trigger.Ate);
        }

        public void PetAnimal()
        {
            _moodMachine.Fire(Trigger.Pet);
        }
        
        public void Tick()
        {
            AgeMinutes++;
            _moodMachine.Fire(Trigger.TimePassed);
            if (AgeMinutes == 30 || AgeMinutes == 60)
            {
                _stageMachine.Fire(Trigger.TimePassed);
            }
           

        }

        public void Save()
        {
            File.WriteAllLines("pet.txt", new string[]
            {
                Name,
                AgeMinutes.ToString(),
                CurrentMood.ToString(),
                CurrentStage.ToString()
            });
        }

        public static Pet Load()
        {
            if (!File.Exists("pet.txt"))
            {
                return new Pet("Unnamed");
            }

            string[] lines = File.ReadAllLines("pet.txt");
            string name = lines[0];
            int age = int.Parse(lines[1]);
            Mood mood = (Mood)Enum.Parse(typeof(Mood), lines[2]);
            Stage stage = (Stage)Enum.Parse(typeof(Stage), lines[3]);

            return new Pet(name, age, mood, stage);
        }

    }
}
