/* 
TeletextClient Class
*/
function TeletextClient(WebServiceURL)
{
    this.WebServiceURL = WebServiceURL;
}

/*
GetJSONFromService
Requests the JSON-Result of a Webservice Method using jQuery 
The result will be passed asynchronously to the CallbackMethod
*/
TeletextClient.prototype.GetJSONFromService = function(MethodName, Parameters, CallbackMethod)
{
    $.getJSON(
        this.WebServiceURL + MethodName + "?callback=?",
        Parameters,
        CallbackMethod);
}

/*
GetPage
Download the specified Teletext Page
*/
TeletextClient.prototype.GetPage = function(PageNumber, CallbackMethod)
{
    this.GetJSONFromService(
        "GetTeletextSite", 
        {number: PageNumber}, 
        CallbackMethod);    
}

/*
GetMenuStructure
Download the Teletext Menustructure
*/ 
TeletextClient.prototype.GetMenuStructure = function(CallbackMethod)
{
    this.GetJSONFromService(
        "GetMenuStructure", 
        {}, 
        CallbackMethod);
}

 /*
 GetTeletextStructure
 Download the Teletext Strucure
 */  
TeletextClient.prototype.GetTeletextStructure = function(PageNumber, CallbackMethod)
{
    this.GetJSONFromService(
        "GetTeletextStructure", 
        {number: PageNumber}, 
        CallbackMethod);
}

 /*
 GetTeletextSubPage
 Download the Teletext Strucure
 */  
TeletextClient.prototype.GetTeletextSubPage = function(PageNumber, SubPageNumber, CallbackMethod)
{
    this.GetJSONFromService(
        "GetTeletextSubSite", 
        {SiteNumber: PageNumber, subSiteNumber: SubPageNumber},
        CallbackMethod);
}

