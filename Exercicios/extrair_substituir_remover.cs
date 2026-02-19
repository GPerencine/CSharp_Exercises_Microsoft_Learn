const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Localiza a posição inicial e final do valor dentro de <span>
int startIndex = input.IndexOf("<span>") + 6;
int endIndex = input.IndexOf("</span>");

// Extrai a quantidade
quantity = input.Substring(startIndex, endIndex - startIndex);

// Remove as tags <div>
output = input.Replace("<div>", "");
output = output.Replace("</div>", "");

// Substitui &trade; por &reg;
output = output.Replace("&trade;", "&reg;");

// Exibe o resultado
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
