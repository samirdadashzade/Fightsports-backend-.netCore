$('#tabs_slider').sliderPro({
    width: 700,
    height: 500,
    fade: true,
    arrows: true,
    buttons: false,
    fullScreen: true,
    shuffle: true,
    smallSize: 500,
    mediumSize: 1000,
    largeSize: 3000,
    thumbnailArrows: true,
    autoplay: true
});

$('#owl-one').owlCarousel({
    loop:true,
    nav:false,
    dots:true,
    dotsData:true,
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

var wow = new WOW()
wow.init()

$('.for_hover').mouseover (function () {
    $(this).css({backgroundColor : "rgba(200, 0, 0, 1)"})
    $(this).find($('.row_content')).css({"box-shadow" : "0px -16px 37px 12px rgba(200, 0, 0, 1) inset"})
})

$('.for_hover').mouseout (function () {
    $(this).css({backgroundColor : "inherit"})
    $(this).find($('.row_content')).css({"box-shadow" : "0px -16px 37px 12px black inset"})
})


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

const getId = (url) => {
    let regExp = /^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=)([^#\&\?]*).*/;
    let match = url.match(regExp);

    if (match && match[2].length == 11) {
        return match[2];

    } else {
        console.log('url not valid!!!!!');
        return 'error';
    }
}

const getVimeoId = (url) => {
    let regExp = /https:\/\/(www\.)?vimeo.com\/(\d+)($|\/)/;
    let match = url.match(regExp);

    if (match && match[2].length == 9) {
        return match[2];
    } else {
        console.log('url not valid!!!!');
        return 'error';
    }
}

$('.myBtn01').on('click', function () {
    $('#modal').modal('show')

    let myUrl = $(this).find($('.my_url')).text()

    if(myUrl.length > 27){
        myId = getId(myUrl)

        let con = $('body').find('#myCode')

        con.html('<iframe width="653" class="delete" height="386" src="http://www.youtube.com/embed/' + myId + '" frameborder="0" allowfullscreen></iframe>');
    }
    else{
        myId = getVimeoId(myUrl);

        let con = $('body').find('#myCode')

        con.html('<iframe src="https://player.vimeo.com/video/' + myId + '" width="653" class="delete" height="386" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>')
    }
})

const deleteIframe = () => {
    $('.modal').click( () => {
        $('.delete').remove()
    })
}

deleteIframe ()

const upperAreaSets = () => {
    var tabConHeight = $('.sp-slides-container ').height()
    $('.upper_custom').css({height: tabConHeight + 105 + "px"})
}

upperAreaSets()

window.onresize = upperAreaSets

var increaseBtn = $('.adjust_font_size')
var fontcon = $('.main_news_txt01')

increaseBtn.click(function () {
    fontcon.toggleClass('adjust_font')
})