using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MyDietSchedule.Utils
{
    public static class Constants
    {
        public static bool IsDev = true;

        public const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";


        #region --- GUI Values Design ---
        // Sizes
        public static int LoginIconHeight = 150;
        #endregion

        #region --- Login & User Management ---
        public static string LoginUrl = "http://www.test.com/api/Auth/Login";
        public static string NoInternetText = "No Internet Connection, please reconnect.";
        public static string LoginError = "The User and the Password don't match.";
        public static string SettingsScreenTitle = "Settings";
        public static int MinPasswordLength = 6;
        #endregion

        #region Temporal Variables

        public static string ModelsPath = "MyDietSchedule.Models.";

        public static string InitialJson = @"{
          'FoodType' :
          [
            {
              'Id': 1,
              'Name': 'Excepciones',
              'Description': 'Excepciones de dieta.'
            },
            {
              'Id': 2,
              'Name': 'Harinas, almidones o Carbohidratos',
              'Description': 'Son los encargados de brindarnos la energia necesaria para q nuestro organismo funcione correctamente.\nMuchos de ellos nos aportan fibra a la dieta la cual tiene una función importante a nivel gastrointestinal y cardiovascular'
            },
            {
              'Id': 3,
              'Name': 'Frutas',
              'Description': 'Las frutas deben de consumirse diariamente, debido a su aporte de fibra y antioxidantes importantes, asi como vitaminas y minerales.\nPrefiera de distintos colores, ya que cada una debido a su color, posee distintas vitaminas y minerales.'
            },
            {
              'Id': 4,
              'Name': 'Vegetales',
              'Description': 'Los vegetales nos aportan a proporcionar fibra, vitaminas y minerales, importantes como la Vitamina A y el Hierro.'
            },
            {
              'Id': 5,
              'Name': 'Lacteos',
              'Description': 'Los lacteos son una Excelente fuente de calcio y proteina.\nNos ayudan a mantener nuestros huesos y dientes saludables.'
            },
            {
              'Id': 6,
              'Name': 'Proteinas (Carnes)',
              'Description': 'Las carnes son alimentos ricos en proteína, la cual cumple funciones importantes en nuestro cuerpo, como transporte de oxígeno, formacion de músculo, ayuda al sistema inmune, entre otros. \n 1 onza equivale a 30 gramos; aproximadamente a una cajita de fosforos. \n El tamaño de la palma de la mano equivale a 3 porciones de proteina aproximadamente.'
            },
            {
              'Id': 7,
              'Name': 'Azúcares',
              'Description': 'Los azúcares al igual que los carbohidratos nos aportan energía, pero en nuestro organismo se absorben más rápidamente. Es por esto, que se deben de utilizar con moderación para evitar que aumenten el nivel de azúcar en sangre (glucosa), de una forma brusca.'
            },
            {
              'Id': 8,
              'Name': 'Grasas',
              'Description': 'Este grupo de alimentos debe ser consumido en pequeñas cantidades para evitar problemas cardiovasculares y gastrointestinales.\nSe deben de preferir las grasas saludables como aceites de canola, maíz, soya, girasol y oliva, aguacate y frutos secos.'
            }
          ],
          'Food' :
          [
            {
              'Id': 1,
              'Name': 'Pan baguette',
              'Category': 'Panes',
              'FoodTypeId': 2,
              'PortionSize': 4,
              'PortionMeasureType': 'Dedo',
              'Notes': ''
            },
            {
              'Id': 2,
              'Name': 'Pan Cuadrado Blanco o integral',
              'Category': 'Panes',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Tajada',
              'Notes': ''
            },
            {
              'Id': 3,
              'Name': 'Pan Blanco Light',
              'Category': 'Panes',
              'FoodTypeId': 2,
              'PortionSize': 2,
              'PortionMeasureType': 'Tajada',
              'Notes': ''
            },
            {
              'Id': 4,
              'Name': 'Bagel Flat',
              'Category': 'Panes',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': '100kcal'
            },
            {
              'Id': 5,
              'Name': 'Pancake',
              'Category': 'Panes',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': 'Delgado y Mediano'
            },
            {
              'Id': 6,
              'Name': 'Tortilla de Harina Mediana',
              'Category': 'Tortillas',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': '13cm de ancho'
            },
            {
              'Id': 7,
              'Name': 'Tortilla marca Maliche Grande',
              'Category': 'Tortillas',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 8,
              'Name': 'Tortilla marca Maliche Mediana',
              'Category': 'Tortillas',
              'FoodTypeId': 2,
              'PortionSize': 2,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 9,
              'Name': 'Tortilla marca Maliche Pequeña',
              'Category': 'Tortillas',
              'FoodTypeId': 2,
              'PortionSize': 4,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 10,
              'Name': 'Tortilla de Maíz Grande',
              'Category': 'Tortillas',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': '13cm de ancho'
            },
            {
              'Id': 11,
              'Name': 'Cereal Azucarado',
              'Category': 'Cereal Desayuno',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Froot Loops, Chocolate, etc.'
            },
            {
              'Id': 12,
              'Name': 'Cereal Arroz Inflado',
              'Category': 'Cereal Desayuno',
              'FoodTypeId': 2,
              'PortionSize': 1.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Rice Crispies'
            },
            {
              'Id': 13,
              'Name': 'Cereal Sin Azucar',
              'Category': 'Cereal Desayuno',
              'FoodTypeId': 2,
              'PortionSize': 0.75,
              'PortionMeasureType': 'Taza',
              'Notes': 'Cornflakes, Special k, mc. Callums'
            },
            {
              'Id': 14,
              'Name': 'Arroz blanco o integral cocido',
              'Category': 'Cereal',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 15,
              'Name': 'Frijoles Cocidos',
              'Category': 'Legumbres',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Negros y rojos'
            },
            {
              'Id': 16,
              'Name': 'Garbanzos, Petit Pois, Lentejas Cocidos',
              'Category': 'Legumbres',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 17,
              'Name': 'Edamame',
              'Category': 'Legumbres',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 18,
              'Name': 'Cuscús cocido',
              'Category': 'Cereal',
              'FoodTypeId': 2,
              'PortionSize': 0.33,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 19,
              'Name': 'Pasta Cocida',
              'Category': 'Cereal',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Cualquier tipo de Pasta'
            },
            {
              'Id': 20,
              'Name': 'Quinoa Cocida',
              'Category': 'Cereal',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 21,
              'Name': 'Granola',
              'Category': 'Grano',
              'FoodTypeId': 2,
              'PortionSize': 0.25,
              'PortionMeasureType': 'Taza',
              'Notes': 'Regular (Contiene 1 porcion de grasa) y Baja en grasa'
            },
            {
              'Id': 22,
              'Name': 'Salvado (Avena - Trigo)',
              'Category': 'Grano',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 23,
              'Name': 'Ayote sazón, Chayote sazón',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 24,
              'Name': 'Camote',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 25,
              'Name': 'Papa Horneada',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': 'Unidad Mediana'
            },
            {
              'Id': 26,
              'Name': 'Puré',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Papa, camote, yuca, etc'
            },
            {
              'Id': 27,
              'Name': 'Elote Grande',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 28,
              'Name': 'Plátano',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Maduro o Verde'
            },
            {
              'Id': 29,
              'Name': 'Yuca',
              'Category': 'Verdura',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 30,
              'Name': 'Galletas Safari (animales)',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Paquete',
              'Notes': ''
            },
            {
              'Id': 31,
              'Name': 'Galletas',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 3,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 32,
              'Name': 'Galleta tipo sandwich relleno de Queso',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Paquete',
              'Notes': ''
            },
            {
              'Id': 33,
              'Name': 'Snacks',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Paquete',
              'Notes': 'Galleta Maria, Jaleitas, Barritas Special K, Chewy Quaker, galletas Bioland, Biscolite, Cremas Sweetwell'
            },
            {
              'Id': 34,
              'Name': 'Fibra miel, Club Social',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Paquete',
              'Notes': 'Equivale a 1 Carbohidrato y 1/2 Grasa'
            },
            {
              'Id': 35,
              'Name': 'Cremitas',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Paquete',
              'Notes': 'Equivale a 1 Carbohidrato y 1 Grasa'
            },
            {
              'Id': 36,
              'Name': 'Palomitas de maíz (Reventadas)',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 3,
              'PortionMeasureType': 'Taza',
              'Notes': 'Mantequilla: Contiene 1 Grasa, Sin Grasa'
            },
            {
              'Id': 37,
              'Name': 'Pretzel',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': ''
            },
            {
              'Id': 38,
              'Name': 'Helados Paleta Light',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 2,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 39,
              'Name': 'Helados Paleta Tarro',
              'Category': 'Snacks',
              'FoodTypeId': 2,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 40,
              'Name': 'kiwi',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 41,
              'Name': 'Ciruela Pequeña',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 2,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 42,
              'Name': 'Durazno, Nectarina o Melocoton',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 2,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 43,
              'Name': 'Fresas',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1.25,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 44,
              'Name': 'Mandarina mediana',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 45,
              'Name': 'Mandarina pequeña',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 2,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 46,
              'Name': 'Mango pequeño',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 47,
              'Name': 'Manzana mediana',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 48,
              'Name': 'Melon o papaya',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 49,
              'Name': 'Pera',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 50,
              'Name': 'Piña',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 0.75,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 51,
              'Name': 'Banano pequeño',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 52,
              'Name': 'Uvas pequeñas',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 17,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 53,
              'Name': 'Sandia',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 1.25,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 54,
              'Name': 'Jugo Frutas Natural',
              'Category': 'Frutas',
              'FoodTypeId': 3,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 55,
              'Name': 'Brocoli Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 56,
              'Name': 'Brocoli Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 57,
              'Name': 'Remolacha Cocida',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 58,
              'Name': 'Remolacha Cruda',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 59,
              'Name': 'Chayote Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 60,
              'Name': 'Chayote Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 61,
              'Name': 'Ayote tierno Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 62,
              'Name': 'Ayote Tierno Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 63,
              'Name': 'Coliflor Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 64,
              'Name': 'Coliflor Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 65,
              'Name': 'Esparrago Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 66,
              'Name': 'Esparrago Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 67,
              'Name': 'Espinaca Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 68,
              'Name': 'Espinaca Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 69,
              'Name': 'Hoja Verde Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': 'Mostaza, lechuga, repollo'
            },
            {
              'Id': 70,
              'Name': 'Hoja Verde Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': 'Mostaza, lechuga, repollo'
            },
            {
              'Id': 71,
              'Name': 'Palmito Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 72,
              'Name': 'Palmito Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 73,
              'Name': 'Tomate Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 74,
              'Name': 'Tomate Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 75,
              'Name': 'Zanahoria Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 76,
              'Name': 'Zanahoria Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 77,
              'Name': 'Vegetales Mixtos Cocidos',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 78,
              'Name': 'Vegetales Mixtos Crudos',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 79,
              'Name': 'Pepino Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 80,
              'Name': 'Pepino Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 81,
              'Name': 'Hongos Cocidos',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 82,
              'Name': 'Hongos Crudos',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 83,
              'Name': 'Berenjena Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 84,
              'Name': 'Berenjena Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 85,
              'Name': 'Apio Cocido',
              'Category': 'Vegetales Cocidos',
              'FoodTypeId': 4,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 86,
              'Name': 'Apio Crudo',
              'Category': 'Vegetales Crudos',
              'FoodTypeId': 4,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 87,
              'Name': 'Leche Liquida Descremada',
              'Category': 'Descremados',
              'FoodTypeId': 5,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 88,
              'Name': 'Yogurt con o sin sabor Descremado',
              'Category': 'Descremados',
              'FoodTypeId': 5,
              'PortionSize': 0.66,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 89,
              'Name': 'Yogurt Descremado Pequeño',
              'Category': 'Descremados',
              'FoodTypeId': 5,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': 'In Line, Activia Light o Yoplait Light'
            },
            {
              'Id': 90,
              'Name': 'Yogurt Light Descremado Envase Pequeño',
              'Category': 'Descremados',
              'FoodTypeId': 5,
              'PortionSize': 2,
              'PortionMeasureType': 'Unidad',
              'Notes': 'In Line, Activia, Light o Yoplait Light'
            },
            {
              'Id': 91,
              'Name': 'Leche Liquida Semi Descremada',
              'Category': 'Semi Descremados',
              'FoodTypeId': 5,
              'PortionSize': 1,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 92,
              'Name': 'Yogurt sin sabor Semi Descremado',
              'Category': 'Semi Descremados',
              'FoodTypeId': 5,
              'PortionSize': 0.66,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 93,
              'Name': 'Fresco Leche Semi Descremado',
              'Category': 'Semi Descremados',
              'FoodTypeId': 5,
              'PortionSize': 250,
              'PortionMeasureType': 'ml',
              'Notes': ''
            },
            {
              'Id': 94,
              'Name': 'Delactomy Saborizado Semi Descremado',
              'Category': 'Semi Descremados',
              'FoodTypeId': 5,
              'PortionSize': 250,
              'PortionMeasureType': 'ml',
              'Notes': ''
            },
            {
              'Id': 95,
              'Name': 'Silk Semi Descremado',
              'Category': 'Semi Descremados',
              'FoodTypeId': 5,
              'PortionSize': 250,
              'PortionMeasureType': 'ml',
              'Notes': 'Equivale a 1 lacteo y 1 azucar'
            },
            {
              'Id': 96,
              'Name': 'Salchichas',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': 'Bajas en grasa'
            },
            {
              'Id': 97,
              'Name': 'Pechuga, Muslito o alitas',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': 'Bajas en grasa'
            },
            {
              'Id': 98,
              'Name': 'Carne de Res',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': 'Lomito, lomo, bistec, carne molida o Cordero'
            },
            {
              'Id': 99,
              'Name': 'Cerdo',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': 'Chuleta pequeña'
            },
            {
              'Id': 100,
              'Name': 'Pescado',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': 'Preferiblemente tilatia, corvina o dorado'
            },
            {
              'Id': 101,
              'Name': 'Queso tierno, mozarella o jamon',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': ''
            },
            {
              'Id': 102,
              'Name': 'Queso light  o jamon light',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 2,
              'PortionMeasureType': 'Rebanada',
              'Notes': ''
            },
            {
              'Id': 103,
              'Name': 'Huevo',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 104,
              'Name': 'Atun',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 0.33,
              'PortionMeasureType': 'lata',
              'Notes': ''
            },
            {
              'Id': 105,
              'Name': 'Queso Parmesano',
              'Category': 'Proteína animal',
              'FoodTypeId': 6,
              'PortionSize': 1,
              'PortionMeasureType': 'Onza',
              'Notes': ''
            },
            {
              'Id': 106,
              'Name': 'Chocolate',
              'Category': 'Almibar',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 107,
              'Name': 'Maple',
              'Category': 'Dulce',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 108,
              'Name': 'Maple Light',
              'Category': 'Dulce',
              'FoodTypeId': 7,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 109,
              'Name': 'Azucar Regular',
              'Category': 'Dulce',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 110,
              'Name': 'Mermelada Light',
              'Category': 'Mermelada',
              'FoodTypeId': 7,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 111,
              'Name': 'Mermelada Regular',
              'Category': 'Mermelada',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 112,
              'Name': 'Miel de abeja, leche condensada',
              'Category': 'Dulce',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 113,
              'Name': 'Nutella',
              'Category': 'Dulce',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': 'Equivale a 1 azucar y una grasa'
            },
            {
              'Id': 114,
              'Name': 'Aderezos para ensalada sin grasa',
              'Category': 'Salsa',
              'FoodTypeId': 7,
              'PortionSize': 3,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 115,
              'Name': 'Salsa agridulce o barbacoa',
              'Category': 'Salsa',
              'FoodTypeId': 7,
              'PortionSize': 3,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 116,
              'Name': 'Salsa gravy',
              'Category': 'Salsa',
              'FoodTypeId': 7,
              'PortionSize': 0.5,
              'PortionMeasureType': 'Taza',
              'Notes': ''
            },
            {
              'Id': 117,
              'Name': 'Barritas Picapiedra',
              'Category': 'Salsa',
              'FoodTypeId': 7,
              'PortionSize': 2,
              'PortionMeasureType': 'Paquete',
              'Notes': ''
            },
            {
              'Id': 118,
              'Name': 'Bebida Hidratante',
              'Category': 'Deporte',
              'FoodTypeId': 7,
              'PortionSize': 250,
              'PortionMeasureType': 'ml',
              'Notes': 'Gatorade, Powerade'
            },
            {
              'Id': 119,
              'Name': 'Gomita deportiva',
              'Category': 'Deporte',
              'FoodTypeId': 7,
              'PortionSize': 4,
              'PortionMeasureType': 'Unidad',
              'Notes': 'Maximo, 5 Unidades'
            },
            {
              'Id': 120,
              'Name': 'Gel Deportivo',
              'Category': 'Deporte',
              'FoodTypeId': 7,
              'PortionSize': 1,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 121,
              'Name': 'Aceite',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': 'Canola, Oliva, Girasol'
            },
            {
              'Id': 122,
              'Name': 'Aceitunas Verdes',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 10,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 123,
              'Name': 'Aguacate Mediano',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 124,
              'Name': 'Almendras',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 6,
              'PortionMeasureType': 'Unidad',
              'Notes': ''
            },
            {
              'Id': 125,
              'Name': 'Aderezo para Ensalada Ranch light',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 126,
              'Name': 'Aderezo para Ensalada Ranch Regular',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 127,
              'Name': 'Mayonesa Light',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 128,
              'Name': 'Mayonesa Regular',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 129,
              'Name': 'Ketchup',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 130,
              'Name': 'Margarina',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 131,
              'Name': 'Mantequilla Light',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 132,
              'Name': 'Mantequilla Regular',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 1,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 133,
              'Name': 'Queso Crema light',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 3,
              'PortionMeasureType': 'cda',
              'Notes': ''
            },
            {
              'Id': 134,
              'Name': 'Queso Crema Regular',
              'Category': 'Grasas',
              'FoodTypeId': 8,
              'PortionSize': 2,
              'PortionMeasureType': 'cda',
              'Notes': ''
            }
          ]
        }";
        #endregion
    }
}
