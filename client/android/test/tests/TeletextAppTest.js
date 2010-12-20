$(document).ready(function(){
  var imageDataSample = 'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQAQMAAAAlPW0iAAAABlBMVEUAAAD///+l2Z/dAAAAM0lEQVR4nGP4/5/h/1+G/58ZDrAz3D/McH8yw83NDDeNGe4Ug9C9zwz3gVLMDA/A6P9/AFGGFyjOXZtQAAAAAElFTkSuQmCC';

  // test GetPage
  test("test GetPage", function() {
    expect(2);
  
    var client = new Mock();// mocks TeletextClient
        client
        .expects(1)
            .method('GetPage')
            .accepts(100, function(){})
            .callFunctionWith(imageDataSample); 

    testImg = new Image();
    testImg.id = "ImgTeletextPage";
    document.body.appendChild(testImg);

    var app = new TeletextApp(client);
    
    //
    app.ShowPage(100);
    ok(client.verify(), "verify GetPage call");
    
    
    //asynchronous testing
    stop();
    setTimeout(function() {
   	    equals(testImg.src, imageDataSample, "Image data correctly assigned?");
        start();
        document.body.removeChild(testImg);
    }, 100);
    
    
  });
  
  // test AnalyzePage
  test("test AnalyzePage", function() {
    var client = new Mock();// mocks TeletextClient
        client
        .expects(1)
        .accepts(100, function(){})
	    .method('GetTeletextStructure');

    var app = new TeletextApp(client);
    app.AnalyzePage(100);
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

