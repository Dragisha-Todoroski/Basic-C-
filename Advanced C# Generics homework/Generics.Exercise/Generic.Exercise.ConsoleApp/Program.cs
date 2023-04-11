using Generics.Exercise.Domain.Models;

PetStore<Dog> dogStore = new PetStore<Dog>();
PetStore<Cat> catStore = new PetStore<Cat>();
PetStore<Fish> fishStore =  new PetStore<Fish>();

dogStore.Insert(new Dog("Rex", "Labrador", 9, "meat chunks"));
dogStore.Insert(new Dog("Bobby", "Pug", 13, "dog biscuits"));

catStore.Insert(new Cat("Garfield", "British Shorthair", 4, true, 2));
catStore.Insert(new Cat("Timmy", "Ragdoll", 1, false, 9));

fishStore.Insert(new Fish("Herbert", "Koi", 3, "orange", "3"));
fishStore.Insert(new Fish("McKinzey", "Goldfish", 2, "gold", "5"));


dogStore.BuyPet("Rex");
catStore.BuyPet("Garfield");

dogStore.PrintsPets();
catStore.PrintsPets();