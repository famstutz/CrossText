/* Crosstext Page Slider 
inspired by https://github.com/blackdynamo/jQuery-Mobile-Carousel
*/

function CtSlider(parent, options)
{
    this.settings = {
            firstPage: 100,
            duration: 300,
            minimumslide: 20,
            loadPage: function(item, page){},
            pageChanged: function(page){}
        };
        
    $.extend(this.settings, options || {});
    
    this.currentPage = this.settings.firstPage;

    this.Parent = parent;
    this.Items = new Array(3);
    
    
        
    this.Container = $("<div>").addClass("slider")
    this.slideContainer = $("<div>").addClass("slideContainer")    
    
    this.initItems();
    this.setBoundary();
    this.bindTouchEvents();
    
    this.Container.append(this.slideContainer);
    this.Parent.append(this.Container);
}

CtSlider.prototype.hasNext = function(direction)
{
    return (direction == "right" && this.currentPage < 900) 
        || (direction == "left" && this.currentPage > 100);
}

CtSlider.prototype.bindTouchEvents = function()
{
    var slider = this;
    var settings = this.settings;
    var started = false;
    var startX = 0;
    var oriX = 0;
    
    var supportTouch = $.support.touch;
    scrollEvent = "touchmove scroll";
    touchStartEvent = supportTouch ? "touchstart" : "mousedown";
    touchStopEvent = supportTouch ? "touchend" : "mouseup";
    touchMoveEvent = supportTouch ? "touchmove" : "mousemove";
  

    this.slideContainer.bind(touchStartEvent, function(event) 
    {
        var data = event.originalEvent.touches ? event.originalEvent.touches[0] : event;
        started = true;
        startX = data.pageX;
        oriX = slider.slideContainer.position().left;
        event.preventDefault();
    });
    
    
    this.slideContainer.bind(touchStopEvent, function(event) 
    {
        started = false;
        event.preventDefault();
        var slideDelta = Math.abs(startX - event.pageX);
        var adjustment = slider.Width - slideDelta;
            
        if(startX > event.pageX) {
            slider.moveLeft(slideDelta, adjustment);
        }
        else {
            slider.moveRight(slideDelta, adjustment);
        }
    });
    
    this.slideContainer.bind(touchMoveEvent, function(event)
    {
        if(started){
            var data = event.originalEvent.touches ? event.originalEvent.touches[0] : event;
            slider.slideContainer.css("left", oriX + data.pageX - startX);       
            event.preventDefault();
        }
    });
   
}

CtSlider.prototype.insertLeft = function() 
{
    var last = this.Items[2];   
    this.Items[2] = this.Items[1];
    this.Items[1] = this.Items[0];
    this.Items[0] = this.createItem(this.currentPage - 1);
    this.slideContainer.prepend(this.Items[0]);
    last.remove();
    this.correctslideContainerPos();
}

CtSlider.prototype.insertRight = function() 
{
    var first = this.Items[0];   
    this.Items[0] = this.Items[1];
    this.Items[1] = this.Items[2];
    this.Items[2] = this.createItem(this.currentPage + 1);
    this.slideContainer.append(this.Items[2]);
    first.remove();
    this.correctslideContainerPos();
}

CtSlider.prototype.correctslideContainerPos = function()
{
    this.slideContainer.css("left", - this.Width);       
}

CtSlider.prototype.moveLeft = function(slideDelta, adjustment)
{
    var slider = this;
    if (!this.hasNext("right") || slideDelta < this.settings.minimumslide) {
        this.slideContainer.animate({ left: "+=" + slideDelta}, this.settings.duration, function(){ slider.correctslideContainerPos(); });
        return;
    }
    this.currentPage++;
    this.slideContainer.animate({ left: "-=" + adjustment}, this.settings.duration, function(){ slider.insertRight(); });
    this.settings.onPageChanged(this.currentPage);
}

CtSlider.prototype.moveRight = function(slideDelta, adjustment)
{
    var slider = this;
    if (!this.hasNext("left") || slideDelta < this.settings.minimumslide) {
        this.slideContainer.animate({ left: "-=" + slideDelta}, this.settings.duration, function(){ slider.correctslideContainerPos(); });
        return;
    }
    this.currentPage--;
    this.slideContainer.animate({ left: "+=" + adjustment}, this.settings.duration, function(){ slider.insertLeft(); });
    this.settings.onPageChanged(this.currentPage);
}


CtSlider.prototype.initItems = function()
{
    for(var i=0; i<3; i++){
        this.Items[i] = this.createItem(this.settings.firstPage + (i-1));
        this.slideContainer.append(this.Items[i]);        
    }
}

CtSlider.prototype.createItem = function(page)
{
    var item = $("<div>").css({
        width: this.Width, 
        height: this.Height
    }).addClass("sliderPage");
    
    
    this.settings.loadPage(item, page);
    return item;
}

CtSlider.prototype.setBoundary  = function()
{
    this.Width = this.Parent.width();
    this.Height = this.Parent.height();
    
    this.Container.css("width", this.Width);
    this.Container.css("height", this.Height);
    this.slideContainer.css("width", 3 * this.Width);
    this.slideContainer.css("height", this.Height); 
    
    for(var i=0; i<this.Items.length; i++){
        this.Items[i].css("width", this.Width);
        this.Items[i].css("height", this.Height);
    }
    this.slideContainer.css("left", - this.Width);
}