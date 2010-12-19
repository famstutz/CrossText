$(document).ready(function(){

  // test GetPage
  test("test GetPage", function() {
    var client = new Mock();// mocks TeletextClient
        client
            .expects(1)
	    .method('GetPage');

    var app = new TeletextApp(client);
    app.ShowPage(100);
    ok(true, "GetPage calls TeletextClient correctly");
  });

  // test AnalyzePage
  test("test AnalyzePage", function() {
    var client = new Mock();// mocks TeletextClient
        client
            .expects(1)
	    .method('GetTeletextStructure');

    var app = new TeletextApp(client);
    app.AnalyzePage(100);
    ok(true, "AnalyzePage calls TeletextClient correctly");
  });

  // test GetMenuStructure
  test("test GetMenuStructure", function() {
    var client = new Mock();// mocks TeletextClient
        client
            .expects(1)
	    .method('GetMenuStructure')
	    .returns('test');

    var app = new TeletextApp(client);
    app.GetMenuStructure();
    ok(true, "GetMenuStructure calls TeletextClient correctly");
  });

});

