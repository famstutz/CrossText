$(document).ready(function(){
  var imageDataSample = 'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQAQMAAAAlPW0iAAAABlBMVEUAAAD///+l2Z/dAAAAM0lEQVR4nGP4/5/h/1+G/58ZDrAz3D/McH8yw83NDDeNGe4Ug9C9zwz3gVLMDA/A6P9/AFGGFyjOXZtQAAAAAElFTkSuQmCC';

  // test GetPage
  test("test PageLoading / Navigation", function() {
       
    // mocks TeletextClient  
    var client = new Mock();
    client
        .expects(1)
            .method('GetPage')
            .accepts(333, function(){})
            .callFunctionWith(imageDataSample)
		.andExpects(1)
			.method('GetTeletextStructure')
			.accepts(333, function(){})
			.callFunctionWith({"__type":"TeletextStructureSite:#CrossText.Service.DataContract","SiteNumber":256,"SubSites":[1,2,3]});
  
                                   

    testImg = new Image();
    testImg.id = "ImgTeletextPage";
    document.body.appendChild(testImg);

    var app = new TeletextApp(client);
    
    //
    app.ShowPage(333);
    
    ok(client.verify(), "verify GetPage calls");
    
    
    //asynchronous testing
    stop();
    setTimeout(function() {
   	    equals(testImg.src, imageDataSample, "Image data correctly assigned?");
        equals(app.CurrentPage, 333, "CurrentPage variable correctly set?");
        equals(app.CurrentSubPage, 0, "Subpage resetted?");
        start();
        document.body.removeChild(testImg);
    }, 50);
    
  });
  
  // test ShowNextPage
  test("test ShowNextPage", function() {
    // mocks TeletextClient  
    var client = new Mock();
    client
        .expects(1)
            .method('GetPage')
            .accepts(334, function(){})
            .callFunctionWith(imageDataSample)
		.andExpects(1)
			.method('GetTeletextStructure')
			.accepts(334, function(){})
			.callFunctionWith({"__type":"TeletextStructureSite:#CrossText.Service.DataContract","SiteNumber":334,"SubSites":[1,2,3]});
                          

    testImg = new Image();
    testImg.id = "ImgTeletextPage";
    
    document.body.appendChild(testImg);

    var app = new TeletextApp(client);
    app.CurrentPage = 333;
 
    //asynchronous testing
    //NextPage
    app.ShowNextPage();
    stop();
    setTimeout(function() {
        ok(client.verify(), "verify GetPage calls");
        equals(app.CurrentPage, 334, "CurrentPage variable set to next page?");
        document.body.removeChild(testImg);
        start();
    }, 50);
    
  });
  
  // test ShowNextPage
  test("test ShowPreviousPage", function() {
    // mocks TeletextClient  
    var client = new Mock();
    client
        .expects(1)
            .method('GetPage')
            .accepts(332, function(){})
            .callFunctionWith(imageDataSample)
		.andExpects(1)
			.method('GetTeletextStructure')
			.accepts(332, function(){})
			.callFunctionWith({"__type":"TeletextStructureSite:#CrossText.Service.DataContract","SiteNumber":332,"SubSites":[1,2,3]});
                          

    testImg = new Image();
    testImg.id = "ImgTeletextPage";
    
    document.body.appendChild(testImg);

    var app = new TeletextApp(client);
    app.CurrentPage = 333;
 
    //asynchronous testing
    //NextPage
    app.ShowPreviousPage();
    stop();
    setTimeout(function() {
        ok(client.verify(), "verify GetPage calls");
        equals(app.CurrentPage, 332, "CurrentPage variable set to previous page?");
        document.body.removeChild(testImg);
        start();
    }, 50);
    
  });

  // test GetSubPageCount
  test("test GetSubPageCount", function() {
    var client = new Mock();// mocks TeletextClient
        client
        .expects(1)
        .accepts(100, function(){})
	    .method('GetTeletextStructure');

    var app = new TeletextApp(client);
	app.CurrentPage = 100;
    app.GetSubPageCount();
    ok(client.verify(), "verify GetTeletextStructure call");
  });

  // test GetMenuStructure
  test("test GetMenuStructure", function() {
    var client = new Mock();// mocks TeletextClient
        client
            .expects(1)
	    .method('GetMenuStructure')
        .accepts(function(){});

    var app = new TeletextApp(client);
    app.GetMenuStructure();
    ok(client.verify(), "verify GetMenuStructure call");
  });
  
  // test SetImageData
  test("test SetImageData", function() {
    var client = new Mock();
    var app = new TeletextApp(client);
    
    var testImg = new Image();
    testImg.id = "testImage";
    document.body.appendChild(testImg);
    
  
    app.SetImageData(imageDataSample, "#testImage");
    equals(testImg.src, imageDataSample, "Image data correctly assigned?");
    
    document.body.removeChild(testImg);
  
  });

});

