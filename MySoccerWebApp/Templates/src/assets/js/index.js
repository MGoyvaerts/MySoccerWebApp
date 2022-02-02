$(function(){
    var owl_ranking_carousel;

    owl_ranking_carousel = $(".owl-carousel__ranking").owlCarousel({
        responsiveClass: true,
        loop: false,
        dots: true,
        nav: false,
        // navText: ["<i class='fa fa-chevron-left'></i>","<i class='fa fa-chevron-right'></i>"],
        stagePadding: 15,
        margin: 30,
        responsive: {
          // breakpoint from 0 up
          0: {
            items: 1
          },
          // breakpoint from 768 up
          768: {
            items: 1
          },
          992: {
            items: 2
          }
        },
        // autoHeight: true
      });
    
      owl_ranking_carousel.owlCarousel({});
});