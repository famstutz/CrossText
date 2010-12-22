/* 
TeletextApp Class
*/
function TeletextApp(WebserviceClient)
{
    this.WebserviceClient = WebserviceClient;
    this.CurrentPage = 0;
    this.CurrentSubPage = 0;
    this.SubPageCount = 0;
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
        var pageNumber = parseInt($("#TxtPageNumber").val());
        app.ShowPage(pageNumber);
    });

    $("#BtnNextPage").click(function()
    {
        app.ShowNextPage();
    });
    
    $("#BtnPrevPage").click(function()
    {
        app.ShowPreviousPage();
    });
    
    
    $("#BtnNextSubPage").click(function()
    {
        app.ShowNextSubPage();
    });
    
    $("#BtnPrevSubPage").click(function()
    {
        app.ShowPreviousSubPage();
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
        app.SetImageData(Data, "#contentImg");
        app.CurrentPage = PageNumber;
        app.CurrentSubPage = 0;
        
        //AnalyzePage to get the SubPageCount
        app.GetSubPageCount(PageNumber);
    }
    
    this.WebserviceClient.GetPage(PageNumber, callback);
}

/*
ShowSubpage
*/
TeletextApp.prototype.ShowSubPage = function(SubPage)
{
    if((this.SubPageCount > 0) && (SubPage > 0) && (SubPage <= this.SubPageCount)){
        
        this.CurrentSubPage = SubPage;
        
        //"this" doesn't work in anonymous functions
        var app = this;
        var callback = function(Data) {
            app.SetImageData(Data, "#ImgTeletextPage");
        }
        
        this.WebserviceClient.GetTeletextSubPage(this.CurrentPage, SubPage,  callback);
    }
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
ShowNextSubpage
*/
TeletextApp.prototype.ShowNextSubPage = function()
{
    if(this.CurrentSubPage < this.SubPageCount){
        this.ShowSubPage(this.CurrentSubPage + 1);
    }
}

/*
ShowPreviousSubpage
*/
TeletextApp.prototype.ShowPreviousSubPage = function()
{
    if(this.CurrentSubPage > 0){
        this.ShowSubPage(this.CurrentSubPage - 1);
    }
}

/*
GetSubPageCount
*/
TeletextApp.prototype.GetSubPageCount = function()
{
    //"this" doesn't work in anonymous functions
    var app = this;

    var callback = function(data) {
        var existingPage, subPageCount;
        // TODO: check for non-existing pages here
        if(data !== null) {
            existingPage = true;
            subPageCount = data.SubSites.length;
    	}
       else {
           // TODO: Show Error-Message
       }
    }

    this.WebserviceClient.GetTeletextStructure(this.CurrentPage, callback);
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

