$('.for_hover').mouseover (function () {
    $(this).css({backgroundColor : "rgba(200, 0, 0, 1)"})
    $(this).find($('.row_content')).css({"box-shadow" : "0px -16px 37px 12px rgba(200, 0, 0, 1) inset"})
})

$('.for_hover').mouseout (function () {
    $(this).css({backgroundColor : "inherit"})
    $(this).find($('.row_content')).css({"box-shadow" : "0px -16px 37px 12px black inset"})
})

$('.tab_for_hover').mouseover (function () {
    $(this).css({backgroundColor : "rgba(200, 0, 0, 1)"})
    $(this).find($('.tab_row_content')).css({"box-shadow" : "0px -16px 37px 12px rgba(200, 0, 0, 1) inset"})
})

$('.tab_for_hover').mouseout (function () {
    $(this).css({backgroundColor : "inherit"})
    $(this).find($('.tab_row_content')).css({"box-shadow" : "0px -16px 37px 12px black inset"})
})

$('.foto_tab_for_hover').mouseover (function () {
    $(this).css({backgroundColor : "rgba(200, 0, 0, 1)"})
    $(this).find($('.foto_tab_row_content')).css({"box-shadow" : "0px -16px 37px 12px rgba(200, 0, 0, 1) inset"})
})

$('.foto_tab_for_hover').mouseout (function () {
    $(this).css({backgroundColor : "inherit"})
    $(this).find($('.foto_tab_row_content')).css({"box-shadow" : "0px -16px 37px 12px black inset"})
})

$('.master_tab_for_hover').mouseover (function () {
    $(this).css({backgroundColor : "rgba(200, 0, 0, 1)"})
    $(this).find($('.master_tab_row_content')).css({"box-shadow" : "0px -16px 37px 12px rgba(200, 0, 0, 1) inset"})
})

$('.master_tab_for_hover').mouseout (function () {
    $(this).css({backgroundColor : "inherit"})
    $(this).find($('.master_tab_row_content')).css({"box-shadow" : "0px -16px 37px 12px black inset"})
})

$('.news_tab_container_items').mouseover (function () {
    $(this).css({backgroundColor: "black"})
})

$('.news_tab_container_items').mouseout (function () {
    $(this).css({backgroundColor: "rgb(128, 128, 128)"})
})

$('.person_padd').mouseover (function () {
    $(this).css({backgroundColor: "#7f7f7f"})
})

$('.person_padd').mouseout (function () {
    $(this).css({backgroundColor: "black"})
})

$('.product_main').mouseover (function () {
    $(this).css({backgroundColor: "#7f7f7f"})
})

$('.product_main').mouseout (function () {
    $(this).css({backgroundColor: "black"})
})

$('#owl-one').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:true,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-two').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:true,
    items:1,
    animateIn: 'slideInDown',
    animateOut: 'slideOutDown',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-three').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInDown',
    animateOut: 'slideOutDown',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-four').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-five').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'fadeInUp',
    animateOut: 'fadeOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-six').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'fadeIn',
    animateOut: 'fadeOut',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-seven').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-eight').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-nine').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-ten').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-eleven').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:3500,
    autoplaySpeed:2500,
    mouseDrag:false,
    items:1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-twelve').owlCarousel({
    loop: true,
    nav: false,
    dots: false,
    dotsData: false,
    autoplay: true,
    autoplayTimeout: 3500,
    autoplaySpeed: 2500,
    mouseDrag: true,
    items: 1,
    animateIn: 'slideInUp',
    animateOut: 'slideOutUp',
    responsive: {
        0: {
            items: 1
        }
    }
});

const getId = (url) => {
    let regExp = /^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=)([^#\&\?]*).*/;
    let match = url.match(regExp);

    if (match && match[2].length === 11) {
        return match[2];

    } else {
        console.log('url not valid!!!!');
        return 'error';
    }
};

const getVimeoId = (url) => {
    let regExp = /https:\/\/(www\.)?vimeo.com\/(\d+)($|\/)/;
    let match = url.match(regExp);

    if (match && match[2].length === 9) {
        return match[2];
    } else {
        console.log('url not valid!!!!');
        return 'error';
    }
};

$('.myBtn01').on('click', function () {
    $('#modal').modal('show');

    let myUrl = $(this).find($('.my_url')).text();

    if (myUrl.length > 27) {
        myId = getId(myUrl);

        let con = $('body').find('#myCode');

        con.html('<iframe width="653" class="delete" height="386" src="http://www.youtube.com/embed/' + myId + '" frameborder="0" allowfullscreen></iframe>');
    }
    else {
        myId = getVimeoId(myUrl);

        let con = $('body').find('#myCode')

        con.html('<iframe src="https://player.vimeo.com/video/' + myId + '" width="653" class="delete" height="386" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>')
    }
});

const deleteIframe = () => {
    $('.modal').click(() => {
        $('.delete').remove();
    });
};

deleteIframe();

$('.myBtn02').on('click', function () {
    $('#modal02').modal('show');
});

var twitterShare = document.querySelector('[data-js="twitter-share"]');

twitterShare.onclick = function(e) {
  e.preventDefault();
  var twitterWindow = window.open('https://twitter.com/share?text=' + encodeURIComponent(location.href), 'twitter-popup', 'height=350,width=600');
  if(twitterWindow.focus) { twitterWindow.focus(); }
    return false;
  }

var facebookShare = document.querySelector('[data-js="facebook-share"]');

facebookShare.onclick = function(e) {
  e.preventDefault();
  var facebookWindow = window.open('https://www.facebook.com/sharer/sharer.php?u=' + encodeURIComponent(location.href), 'facebook-popup', 'height=350,width=600');
  if(facebookWindow.focus) { facebookWindow.focus(); }
    return false;
}

var vkShare = document.querySelector('[data-js="vk-share"]');

vkShare.onclick = function(e) {
  e.preventDefault();
  var vkWindow = window.open('http://vkontakte.ru/share.php?url=' + encodeURIComponent(location.href), 'vk-popup', 'height=350,width=600');
  if(vkWindow.focus) { vkWindow.focus(); }
    return false;
}

var inShare = document.querySelector('[data-js="in-share"]');

inShare.onclick = function(e) {
  e.preventDefault();
  var inShare = window.open('http://www.linkedin.com/shareArticle?mini=true&url=' + encodeURIComponent(location.href), 'vk-popup', 'height=350,width=600');
  if(inShare.focus) { inShare.focus(); }
    return false;
}

const tabConTitleWidth = () => {
    let contentTitle = $('.for_res_width')
    let tabRowWidth = $('.tab_row_content').width()

    contentTitle.css({width : tabRowWidth  + "px"})
}

tabConTitleWidth ()

window.onload = function () {
    tabConTitleWidth()
}

window.onresize = function () {
    tabConTitleWidth()
}