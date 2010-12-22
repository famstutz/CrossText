/* 
TeletextApp Class
*/
function TeletextApp(WebserviceClient)
{
    this.WebserviceClient = WebserviceClient;
    this.CurrentPage = 0;
    this.CurrentSubPage = 0;
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
        var pageNumber = $("#TxtPageNumber").val();
        app.ShowPage(pageNumber);
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
        app.CurrentPage = PageNumber;
        app.CurrentSubPage = 0;
    }
    
    this.WebserviceClient.GetPage(PageNumber, callback);
}

/*
ShowNextPage
*/
TeletextApp.prototype.ShowNextPage = function(){
    this.ShowPage(this.CurrentPage+1);
}

/*
ShowPreviousPage
*/
TeletextApp.prototype.ShowPreviousPage = function(){
    this.ShowPage(this.CurrentPage-1);
}

/*
AnalyzePage
*/
TeletextApp.prototype.AnalyzePage = function(PageNumber)
{
    //"this" doesn't work in anonymous functions
    var app = this;

    var callback = function(Data) {
        var SubPageCount = 0;
        if(Data != null) {
            SubPageCount = Data.SubSites.length;     
            /*$.each(Data.SubSites, function(index, value) {
                SubPageCount++;                
    	    });*/
    	}
        //alert(SubPageCount);   
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

