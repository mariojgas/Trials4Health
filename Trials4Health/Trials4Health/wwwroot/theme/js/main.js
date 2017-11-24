jQuery(document).ready(function($){
    
    // Bootstrap menu fix
    $(".navbar-toggle").click(function(){
        $(".header").css('background', '#000');
    });
    
    
    $(".navbar-nav li a").click(function(){
        $(".navbar-collapse").removeClass('in');
    });
    
	$('#tweet').twittie({
        count: 1,
        template: '{{tweet}}'
    });
    
    
    // jQuery sticky menu
    $(".header").sticky({topSpacing:0});

    // jQuery smooth scroll
    $('.navbar-nav li a, .scroll-to-bottom a').bind('click', function(event) {
        var $anchor = $(this);
        var headerH = '70';
        $('html, body').stop().animate({
            scrollTop : $($anchor.attr('href')).offset().top - headerH + "px"
        }, 1200, 'easeInOutExpo');

        event.preventDefault();
    }); 
    
    
    
    // jQuery scroll psy
    $('body').scrollspy({ 
        target: '.navbar-collapse',
        offset: 95
    }); 
    
    // jQuery counter
    $('.counter').counterUp({
        delay: 10,
        time: 1000
    });     

    // Owl Carousel
    $('.article-list').owlCarousel({
        loop:true,
        margin:10,
        responsiveClass:true,
        autoplay: 5000,
        nav:true,
		navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        responsive:{
            0:{
                items:1
            },
            600:{
                items:2
            },
            1000:{
                items:3
            }
        }
    });

    // Owl Carousel
    $('.client-list').owlCarousel({
        loop:true,
        margin:10,
        responsiveClass:true,
        autoplay: 5000,
		nav:true,
		navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],        
        responsive:{
            0:{
                items:1
            },
            600:{
                items:4
            },
            1000:{
                items:6
            }
        }
    });
    

    // Owl Carousel
    $('.old-event-list').owlCarousel({
        loop:true,
        margin:10,
        responsiveClass:true,
        autoplay: 5000,
		nav:true,
		navText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],        
        responsive:{
            0:{
                items:1
            },
            600:{
                items:2
            },
            1000:{
                items:3
            }
        }
    });
    
    
    $('.portfolio-menu li').click(function(){ 
        
      $(".portfolio-menu li").removeClass("active");
      $(this).addClass("active");        

        var selector = $(this).attr('data-filter'); 
        $(".portfolio-items").isotope({ 
            filter: selector, 
            animationOptions: { 
                duration: 750, 
                easing: 'linear', 
                queue: false, 
            } 
        }); 
      return false; 
    });      
    
    
});


jQuery(window).load(function(){
     
    // Active isotope in container
    
    $(".portfolio-items").isotope({
        itemSelector: '.single-portfolio',
        layoutMode: 'fitRows',
    });    
    
});