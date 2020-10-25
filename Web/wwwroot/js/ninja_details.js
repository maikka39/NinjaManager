$(document).ready(function(){
    // Cache the highest
    let highestBox = 0;
    let cards = $('.fixed-card-size');
    
    // Select and loop the elements you want to equalise
    cards.each(function(){
        // If this box is higher than the cached highest then store it
        if($(this).height() > highestBox) {
            highestBox = $(this).height();
        }
    });
    
    // Select and loop the container element of the elements you want to equalise
    cards.each(function(){

        // Set the height of all those children to whichever was highest 
        $('.fixed-card-size').height(highestBox);

    });
});