$(document).ready(function(){
        $('.list').click(function(){
            const value = $(this).attr('data-filter');
            if(value == 'all'){
                $('.itembox').show(1000);
            }
            else{
                $('.itembox').not('.' +value).hide('3000');
                $('.itembox').filter('.' +value).show('3000');
            }
        })

        // Add active List//
        $('.list').click(function(){
            $(this).addClass('active').siblings().removeClass('active');
        })
        $('.menulistz').click(function(){
            $(this).addClass('activemenu').siblings().removeClass('activemenu');
        })
        $('.dateicon1').click(function(){
            $('.detalpar1').slideToggle('1000');
        })
        $('.dateicon2').click(function(){
            $('.detalpar2').slideToggle('1000');
        });
        $('.dateicon3').click(function(){
            $('.detalpar3').slideToggle('1000');
        });
        $('.dateicon4').click(function(){
            $('.detalpar4').slideToggle('1000');
        })
})