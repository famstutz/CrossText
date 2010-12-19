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
    //"this" doesn't work in anonymous functions 
    var app = this;
    
    $("#MenuStructure").click(function()
    {
        app.GetMenuStructure();
    });
    
    $("#BtnLoadPage").click(function()
    {
        var PageNumber = $("#TxtPageNumber").val();
        app.ShowPage(PageNumber);
    });

    $("#BtnTestPage").click(function()
    {
        var pageNumber = $("#TxtPageNumber").val();
        app.AnalyzePage(pageNumber);
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
    //"this" doesn't work in anonymous functions
    var app = this;
    
    var callback = function(Data) {
        app.SetImageData(Data, "#ImgTeletextPage");
    }
    
    this.WebserviceClient.GetPage(PageNumber, callback);
}

/*
AnalyzePage
*/
TeletextApp.prototype.AnalyzePage = function(PageNumber)
{
    //"this" doesn't work in anonymous functions
    var app = this;

    var callback = function(data) {
	//alert(data);
    }

    this.WebserviceClient.GetTeletextStructure(PageNumber, callback);
}

/*
GetMenuStructure
*/
TeletextApp.prototype.GetMenuStructure = function()
{
    var callback = function(Data)
    {
	if(Data != null) {
	    $.each(Data, function(index, value) {
		alert(value.Title);
	    });
	}
    } 
    
    this.WebserviceClient.GetMenuStructure(callback);
}

