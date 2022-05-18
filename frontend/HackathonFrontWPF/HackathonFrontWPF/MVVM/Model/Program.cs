using System.Net.Http;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

using System.Net.Http.Json;
using Newtonsoft.Json;
using HackathonFrontWPF;
using Network;
using my_user_control;
// use the name space  HackathonFrontWPF



Console.WriteLine("Hello, World!");

var test_user = new
{
    UserName = "Steve Gordon",
    Email = "omerli1197@gmail.com",
    Password = "1234",
    Vegeterian = true,
    Vegan = false,
    Kosher = false,
    NoGluten = false,
    NoSoy = false,
    NoMilk = false,
    NoNuts = true
};
//  create this var string name, string image_path, float price, float quantity
string Name = "Coca Cola";
string Image_path = "https://www.coca-cola.com/content/dam/ccstore/images/product/bottles/coca-cola-classic-bottle-can-330ml-1.png";
float Price = 5;
float Quantity = 10;
int time = 35;



int Time_recipy = 20;
string Name_reciipy = "Humborger";
string Description_recipy = " very nice humborger";
string Image_path_recipy = "reand the image path";
// create an List of Ingredient
List<Ingredient> Ingredients = new List<Ingredient>();
// add new Ingredient to the list
// var postResponse = await client.PostAsJsonAsync("http://172.29.120.240:8080/register_user", postUser);

// var json_user = JsonConvert.SerializeObject(postUser);

// HttpClient client = new HttpClient();

//var postResponse = await client.PostAsJsonAsync("http://172.29.120.240:8080/register_user", postUser);

//Console.WriteLine(postResponse);
// get the return value into string and 
//string jsonStr = postResponse.Content.ReadAsStringAsync().Result;
//Console.WriteLine(jsonStr);
//User user = JsonConvert.DeserializeObject<User>(jsonStr);
//Console.WriteLine(user.UserName);


//var recepie_json = await postResponse.Content.ReadFromJsonAsync<RecipeClass>();



// port 8080
//register_user
//recieves user, sends back json with all ingridients


//add_ingridient
//recieves single ingridient, sends back json with all recipes
static void convert_ingridient_to_json(Ingredient ingridient)
{
    // convert ingridient to json
    // send to server
    // get back json with all recipes
    //var json = JsonConvert.SerializeObject(ingre_example);
    //string jsonified = JsonConvert.SerializeObject(ingre_example);
    //System.IO.File.WriteAllText(@"C:\Users\omerl\OneDrive\Desktop\New folder\Network\Network\User_jason", json);
}













async static Task generate_User_json()
{
    var test_user = new
    {
        UserName = "Steve Gordon",
        Email = "omerli1197@gmail.com",
        Password = "1234",
        Vegeterian = true,
        Vegan = false,
        Kosher = false,
        NoGluten = false,
        NoSoy = false,
        NoMilk = false,
        NoNuts = true
    };
    HttpClient client = new HttpClient();
    var json = JsonConvert.SerializeObject(test_user);
    var postResponse = await client.PostAsJsonAsync("http://172.29.120.240:8080/register_user", json);
    // create a List of Ingredient from postResponse
    List<Ingredient> recipies = JsonConvert.DeserializeObject<List<Ingredient>>(postResponse.Content.ReadAsStringAsync().Result);
    Console.WriteLine(recipies);
    foreach (var item in recipies)
    {
        Console.WriteLine(item.Name);
        Console.WriteLine(item.Image_path);
        Console.WriteLine(item.Price);
    }

}

// create a function that Send an Ingredient to the server and recieve a json with three numbers
async static Task add_ingredient_json(string name)
{
    // create new Ingredient
    HttpClient client = new HttpClient();
    var json_ingredient = JsonConvert.SerializeObject(name);
    var postResponse = await client.PostAsJsonAsync("http://172.29.120.240:8080/add_ingridient", json_ingredient);
    RecipyStat recipy_statistic = JsonConvert.DeserializeObject<RecipyStat>(postResponse.Content.ReadAsStringAsync().Result);
    Console.WriteLine(recipy_statistic.current_min_price);
    Console.WriteLine(recipy_statistic.paid_recipy_count);
    Console.WriteLine(recipy_statistic.free_recipy_count);
    Console.WriteLine(postResponse);
}


// create a function that Send the server empty string and recive a Json with List of Recipies
// the function will create a recipy and add it to the list
async static Task get_recipies_json()
{
    HttpClient client = new HttpClient();
    var postResponse = await client.PostAsJsonAsync("http://172.29.120.240:8080/generate_recipes", " ");
    // parser a List of Recipies
    List<Recipy> recipies = JsonConvert.DeserializeObject<List<Recipy>>(postResponse.Content.ReadAsStringAsync().Result);
    Console.WriteLine(recipies[0].name);
    Console.WriteLine(recipies[0].directions);
    // write the
}


var new_user = new
{
    UserName = "Steve Gordon",
    Email = "omerli1197@gmail.com",
    Password = "1234",
    Vegeterian = true,
    Vegan = false,
    Kosher = false,
    NoGluten = false,
    NoSoy = false,
    NoMilk = false,
    NoNuts = true
};



HttpClient client = new HttpClient();


Console.ReadLine();

var json = JsonConvert.SerializeObject(test_user);
var postResponse_56 = await client.PostAsJsonAsync("http://172.29.120.240:8080/register_user", json);
// create a List of Ingredient from postResponse
List<Ingredient> recipies = JsonConvert.DeserializeObject<List<Ingredient>>(postResponse_56.Content.ReadAsStringAsync().Result);
Console.WriteLine(recipies);
foreach (var item in recipies)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Image_path);
    Console.WriteLine(item.Price);
}
Console.ReadLine();



/// <summary>
/// /
/// </summary>
var json_ingredient = JsonConvert.SerializeObject("potatoes");
var postResponse = await client.PostAsJsonAsync("http://172.29.120.240:8080/add_ingredient", json_ingredient);
RecipyStat recipy_statistic = JsonConvert.DeserializeObject<RecipyStat>(postResponse.Content.ReadAsStringAsync().Result);
Console.WriteLine(recipy_statistic.current_min_price);
Console.WriteLine(recipy_statistic.paid_recipy_count);
Console.WriteLine(recipy_statistic.free_recipy_count);
Console.WriteLine(postResponse);
Console.ReadLine();

var json_ingredient_1 = JsonConvert.SerializeObject("chicken");
var postResponse_1 = await client.PostAsJsonAsync("http://172.29.120.240:8080/add_ingredient", json_ingredient_1);
RecipyStat recipy_statistic_1 = JsonConvert.DeserializeObject<RecipyStat>(postResponse_1.Content.ReadAsStringAsync().Result);
Console.WriteLine(recipy_statistic.current_min_price);
Console.WriteLine(recipy_statistic.paid_recipy_count);
Console.WriteLine(recipy_statistic.free_recipy_count);
Console.WriteLine(postResponse);
Console.ReadLine();



var json_ingredient_2 = JsonConvert.SerializeObject("garlic");
var postResponse_2 = await client.PostAsJsonAsync("http://172.29.120.240:8080/add_ingredient", json_ingredient_2);
RecipyStat recipy_statistic_2 = JsonConvert.DeserializeObject<RecipyStat>(postResponse_2.Content.ReadAsStringAsync().Result);
Console.WriteLine(recipy_statistic.current_min_price);
Console.WriteLine(recipy_statistic.paid_recipy_count);
Console.WriteLine(recipy_statistic.free_recipy_count);
Console.WriteLine(postResponse);




var postResponse_3 = await client.PostAsJsonAsync("http://172.29.120.240:8080/generate_recipes", "");
RecipyStat recipy_statistic_3 = JsonConvert.DeserializeObject<RecipyStat>(postResponse_3.Content.ReadAsStringAsync().Result);
Console.WriteLine(recipy_statistic.current_min_price);
