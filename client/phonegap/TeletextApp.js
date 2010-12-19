/* 
TeletextApp Class
*/
function TeletextApp(WebserviceClient)
{
    this.WebserviceClient = WebserviceClient;
}

/*
RegisterEvents
*/
TeletextApp.prototype.RegisterEvents = function()
{
   $("#MenuStructure").click(function()
    {
        this.GetMenuStructure();
    });
    
    $("#BtnLoadPage").click(function()
    {
        var PageNumber = $("#TxtPageNumber").val();
        ShowPage(PageNumber);
    });
}

/*
SetImageData
*/
TeletextApp.prototype.SetImageData = function(Data, ImageId)
{
    $(ImageId).attr("src", Data);
}

/*
GetPage
*/
TeletextApp.prototype.ShowPage = function(PageNumber)
{
    var callback = function(Data) {
        this.SetImageData(Data, "#ImgTeletextPage");
    }
    
    this.WebserviceClient.GetPage(PageNumber, callback);
}  

    
/*
GetMenuStructure
*/
TeletextApp.prototype.GetMenuStructure = function()
{
    var callback = function(Data)
    {
        $.each(Data, function(index, value) { 
            alert(value.Title); 
        });
    } 
    
    this.WebserviceClient.GetMenuStructure(callback);
}