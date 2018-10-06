$('#owl-one').owlCarousel({
    loop:true,
    nav:false,
    dots:true,
    dotsData:true,
    autoplay:true,
    autoplayTimeout:5000,
    autoplaySpeed:2500,
    mouseDrag:true,
    items:1,
    animateIn: 'fadeInRight',
    animateOut: 'fadeOutLeft',
    responsive:{
        0:{
            items:1
        }
    }
})

$('#owl-two').owlCarousel({
    loop:true,
    nav:false,
    dots:true,
    dotsData:true,
    autoplay:true,
    autoplayTimeout:5000,
    autoplaySpeed:2500,
    mouseDrag:true,
    items:1,
    animateIn: 'fadeInUp',
    animateOut: 'fadeOutDown',
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
    autoplayTimeout:5000,
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
    autoplayTimeout:5000,
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
    autoplayTimeout:5000,
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

$('#owl-six').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:5000,
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

$('#owl-seven').owlCarousel({
    loop:true,
    nav:false,
    dots:false,
    dotsData:false,
    autoplay:true,
    autoplayTimeout:5000,
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
    autoplayTimeout:5000,
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
    autoplayTimeout:5000,
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
    autoplayTimeout:5000,
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
    autoplayTimeout:5000,
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


function overlaySets () {
    var expHeight = $('.main_feed_container').height()
    var expWidth = $('.main_feed_container').width()
    $('.carousel_overlay').css({
        height: expHeight + "px",
        width: expWidth + "px"
    })
}

overlaySets ()

$('.main_feed_container').mouseover (function () {
    $(this).find('.show_more_button').css({backgroundColor: "#c80000",color: "#fff"})
})

$('.main_feed_container').mouseout (function () {
    $(this).find('.show_more_button').css({backgroundColor: "#fff",color: "#c80000"})
})

$('.news_tab_container_items').mouseover (function () {
    $(this).css({backgroundColor: "black"})
})

$('.news_tab_container_items').mouseout (function () {
    $(this).css({backgroundColor: "rgb(128, 128, 128)"})
})

$('.big_small_module_con_item').mouseover (function () {
    $(this).css({backgroundColor: "black"})
})

$('.big_small_module_con_item').mouseout (function () {
    $(this).css({backgroundColor: "rgb(128, 128, 128)"})
})

$('.biggest_small_module_con_item').mouseover (function () {
    $(this).css({backgroundColor: "black"})
})

$('.biggest_small_module_con_item').mouseout (function () {
    $(this).css({backgroundColor: "rgb(128, 128, 128)"})
})

// function SetRowContentItemSets () {
//     var expWidth01 = $('.img_example').width()
//     $('.row_content').css({width: expWidth01 + 2 + "px"})

//     var expWidth02 = $('.tab_img_example').width()
//     $('.tab_row_content').css({width: expWidth02 + 2 + "px"})

//     // var expWidth03 = $('.foto_tab_img_example').width()
//     // $('.foto_tab_row_content').css({width: expWidth03 + 2 + "px"})
// }

// SetRowContentItemSets ()


window.onload = function () {
    overlaySets ()
    // SetRowContentItemSets ()
}

window.onresize = function () {
    overlaySets ()
    // SetRowContentItemSets ()
}

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

// $('.footer_footer').mouseover(function () {
//     $('.footer_container').css({height: '328px'})
// })

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

let mainImgCon = $('.con_item')
let targetImgCon = $('.img_main')
let exampleImgCon = $('.main_img_example')

mainImgCon.mouseover(function  () {
    let thisElem = $(this).find(exampleImgCon)
        
    let src = thisElem.css('backgroundImage')

    let end = targetImgCon.css({backgroundImage : src})
})

mainImgCon.trigger('mouseover')

mainImgCon.click(function () {
    $(this).find($('.con_item_txt_container_main')).toggleClass('showHide')
})      

function accordionSets () {
    let width = $('.img_main').width()
    $('.items_container').css({width : width})
}

window.onload = function () {
    accordionSets()
}

window.onresize = function () {
    accordionSets()
}