var Page = {
    createChartPie: function() {

        var chartPieData = [
            {
                "label": "Series1",
                "data": 44,
                "color": "#41D492"
            },
            {
                "label": "Series2",
                "data": 40,
                "color": "#5C59ED"
            },
            {
                "label": "Series3",
                "data": 16,
                "color": "#F2B51D"
            }
        ];

        var chartPieOptions = {
            series: {
                pie: {
                    show: true,
                    innerRadius: 0.6,
                    label: {
                        show: false
                    }
                }
            },
            legend: {
                show: false
            }
        };

        $.plot('#chart-pie', chartPieData, chartPieOptions);
    },
    createWorldMap: function() {

        var mapData = {
            "US": 298,
            "SA": 200,
            "DE": 220,
            "FR": 540,
            "CN": 120,
            "AU": 760,
            "BR": 550,
            "IN": 200,
            "GB": 120,
        };

        $('#world-map').vectorMap({
            map: 'world_mill',
            backgroundColor: "transparent",
            regionStyle: {
                initial: {
                    fill: '#e4e4e4',
                    "fill-opacity": 0.9,
                    stroke: 'none',
                    "stroke-width": 0,
                    "stroke-opacity": 0
                }
            },

            series: {
                regions: [{
                    values: mapData,
                    scale: ["#34A874", "#41D492"],
                    normalizeFunction: 'polynomial'
                }]
            },
        });
    },
    createSalesSlider: function() {
        $('.resellers-slider').bxSlider({
            mode: 'vertical',
            auto: true,
            controls: false,
            pager: false,
            pause: 6000
        });
    },
    createCalendar: function() {
        $(".calendar").zabuto_calendar({
            language: "en",
            cell_border: false,
            today: true,
            show_days: true,
            nav_icon: {
              prev: '<i class="ion ion-ios-arrow-left"></i>',
              next: '<i class="ion ion-ios-arrow-right"></i>'
            }
          });
    },
    createToDoList: function() {
        $('.todo-item').on('click', function(e){
            e.preventDefault();
            $(this).toggleClass('done');
            $(this).find('.checkbox').toggleClass('fa-check-square').toggleClass('fa-square-o');
        });
    },
    init:function() {
        this.createChartPie();
        this.createWorldMap();
        this.createSalesSlider();
        this.createCalendar();
        this.createToDoList();
    }
}
