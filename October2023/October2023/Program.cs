using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser
IWebDriver driver = new ChromeDriver(); //instance of a browser 
driver.Manage().Window.Maximize();

//launch TurnUp Portal and navigate to the website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?");
Thread.Sleep(2000);

//identify username textbox and enter valid username
IWebElement userNameTextbox = driver.FindElement(By.Id("UserName"));
userNameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//check if user logged in successfully 
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User logged in successfully");
}

else
{
    Console.WriteLine("User hasn't been logged in successfully");
}


//create new time record

//Navigate to Time and Material module
IWebElement administrationOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationOption.Click();

IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterial.Click();

//click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

//select Time from Typecode dropdown
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
typeCodeDropdown.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();

//enter Code in code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("October2023");

//enter description in description textbox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("123123");

//enter price in price per unit textbox
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("12");

//click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(4000);

//check if time record has been created successfully 
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "October2023")
{
    Console.WriteLine("New record has been created successfully");
}
else
{

    Console.WriteLine("New Record has not been created");
}