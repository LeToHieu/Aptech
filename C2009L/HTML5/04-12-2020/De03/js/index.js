$(document).ready(function() {
    
})

function navigatePage(event) {
    if(event.id == "home") {
        debugger        
            
    }else if(event.id == "gallery") {
        $("#pageName").load("gallery.html"); 
    }else if(event.id == "order") {
        $("#pageName").load("order.html"); 
    }else if(event.id == "phone") {
        $("#pageName").load("gallery.html"); 
    }else if(event.id == "tablet") {
        $("#pageName").load("gallery.html"); 
    }else if(event.id == "laptop") {
        $("#pageName").load("gallery.html"); 
    }
}