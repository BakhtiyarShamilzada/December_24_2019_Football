$(document).ready(function () {

    $(document).on('click', '#DeleteFootballPlayer', function (e) {
        var FootballPlayerId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByFootballPlayerId?FootballPlayerId=" + FootballPlayerId,
                            type: "POST",
                            success: function (res) {
                                $("table").fadeIn();
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

    $(document).on('click', '#DeleteFootballCart', function (e) {
        var FootballCartId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByFootballCartId?FootballCartId=" + FootballCartId,
                            type: "POST",
                            success: function (res) {
                                $("table").fadeIn();
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

    $(document).on('click', '#DeleteGameTime', function (e) {
        var GameTimeId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByGameTimeId?GameTimeId=" + GameTimeId,
                            type: "POST",
                            success: function (res) {
                                $("table").fadeIn();
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

    $(document).on('click', '#DeleteStadium', function (e) {
        var StadiumId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByStadiumId?StadiumId=" + StadiumId,
                            type: "POST",
                            success: function (res) {
                                $("table").fadeIn();
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

    $(document).on('click', '#search', function () {
        let date1 = $('#date-1').val();
        let date2 = $('#date-2').val();
        let positionId = $('#position').val();
        let cartId = $('#cart').val();
        console.log(date1)
        console.log(date2)
        console.log(positionId)
        console.log(cartId)
        $.ajax(
            {
                url: "/Ajax/FilterFootballCart?date1=" + date1 + "&date2=" + date2 + "&positionId=" + positionId + "&cartId=" + cartId,
                type: "POST",
                success: function (res) {
                    $("table").fadeIn();
                    $("tbody").html(res);
                },
                error: function () {
                    swal("An error occurred !", {
                        icon: "error",
                    });
                }
            });
    })

    $('.football-players-id').each(function () {
        if ($(this).prop('checked') == true) {
            let footballPlayerId = $(this).attr('data-football-players-id');
            $('#FootballPlayersId').val($('#FootballPlayersId').val() + footballPlayerId + ",");
        }
    })

    $(document).on('click', '.football-players-id', function () {
        let footballPlayerId = $(this).attr('data-football-players-id');
        if ($(this).prop('checked') == true) {
            $('#FootballPlayersId').val($('#FootballPlayersId').val() + footballPlayerId + ",");
        }
        else {
            let arr = $('#FootballPlayersId').val().split(',');
            arr = arr.filter(el => el != footballPlayerId);
            $('#FootballPlayersId').val(arr.join(','));
        }

    })

    $(document).on('change', '#CreatePhoto', function (e) {
        if ($(this).val() != "") {
            if ([...e.target.files][0].type.match("image/*")) {
                let reader = new FileReader();
                reader.onloadend = function (read) {
                    $('#CurrentImageArea').fadeIn();
                    $('#CurrentImage').attr('src', read.target.result);
                }
                reader.readAsDataURL([...e.target.files][0]);
            }
        }
    })

    $(document).on('change', '#football-player', function () {
        var footballPlayerId = $(this).val();
        if (footballPlayerId) {
            $.ajax(
                {
                    url: "/Ajax/LoadSelectGameTimesByFootballPlayerId?FootballPlayerId=" + footballPlayerId,
                    type: "POST",
                    success: function (res) {
                        $("#game-time").html(res).prepend("<option disabled selected >Choose</option>");
                    },
                    error: function () {
                        swal("Xəta baş verdi !", {
                            icon: "error",
                        });
                    }
                })
        }
    })

    $(document).on('change', '#team-1', function () {
        var team1Id = $(this).val();
        if (team1Id) {
            $.ajax(
                {
                    url: "/Ajax/LoadSelectTeamsByTeamId?TeamId=" + team1Id,
                    type: "POST",
                    success: function (res) {
                        $("#team-2").html(res).prepend("<option disabled selected >Choose</option>");
                    },
                    error: function () {
                        swal("Xəta baş verdi !", {
                            icon: "error",
                        });
                    }
                })
        }
    })

    // Select initial date from `eventDates`
    $picker = $('.datepicker-here').each(function () {
        var currentDate = currentDate = new Date();
        $(this).data('datepicker').selectDate(new Date(currentDate.getFullYear(), currentDate.getMonth(), currentDate.getDate()));
    })

    $('.teams').draggable({ revert: true });

    $('.player').droppable({
        activeClass: 'active',
        hoverClass: 'hover',
        drop: function (e, ui) {
            let footballerId = ui.draggable.attr('data-id');
            ui.draggable.attr('data-id', 'undefined')
            let dataFirstName = $(this).attr('data-first-name');
            let dataName = ui.draggable.attr('data-name');
            let draggableSrc = ui.draggable.find('img').attr('src');
            let dataId = $(this).attr('data-id');

            $(this).attr('data-id', footballerId);

            // ADD FOOTBALLER TO FULL FOOTBALLER
            if (dataId !== "undefined") {
                let src = $(this).find('img').attr('src');
                $(this).find('img').attr('src', draggableSrc).attr('data-id', footballerId);
                ui.draggable.attr('data-id', dataId).find('img').attr('src', src);
                ui.draggable.find('h6').text(dataFirstName);
            }

            // ADD FOOTBALLER EMPTY POSITION
            else {
                $(this).find('img').attr('src', ui.draggable.parent().remove().find('img').attr('src'));
            }

            let color1 = $('#Color1').val();
            let color2 = $('#Color2').val();

            if ($(this).attr('data-side') === 'home') {
                $(this).find('.player__img').css('border', '4px solid' + color1);
            }
            else {
                $(this).find('.player__img').css('border', '4px solid' + color2);
            }

            $(this).attr('data-first-name', ui.draggable.attr('data-first-name'));
            ui.draggable.attr('data-first-name', dataFirstName);

            $('#FootballersIdPositionsId').val('');
            $('.player').each(function () {

                if ($(this).attr('data-id') != "undefined") {
                    let footballerIdPositionId = $(this).attr('data-id') + "-" + $(this).attr('data-name') + ",";
                    $('#FootballersIdPositionsId').val($('#FootballersIdPositionsId').val() + footballerIdPositionId)
                }
            })
        }
    });

    $(document).on('click', '#team-2', function () {
        let psoitionType1Id = $('#PositionType1Id').val();
        let psoitionType2Id = $('#PositionType2Id').val();
        $('.team-2-area').fadeIn();
        $('.team-1-area').hide();
        $('.team').removeClass('position-type-' + psoitionType1Id).addClass('position-type-' + psoitionType2Id);

        $('.position-type-1-select').hide();
        $('.position-type-2-select').fadeIn();

        $('.team-color-1-area').hide();
        $('.team-color-2-area').fadeIn();
    })

    $(document).on('click', '#team-1', function () {
        let psoitionType1Id = $('#PositionType1Id').val();
        let psoitionType2Id = $('#PositionType2Id').val();
        $('.team-1-area').fadeIn();
        $('.team-2-area').hide();
        $('.team').removeClass('position-type-' + psoitionType2Id).addClass('position-type-' + psoitionType1Id);

        $('.position-type-2-select').hide();
        $('.position-type-1-select').fadeIn();

        $('.team-color-2-area').hide();
        $('.team-color-1-area').fadeIn();
    })

    $(document).on('change', '.position-type', function () {
        let id = $(this).val();

        $('.team').removeClass('position-type-1')
            .removeClass('position-type-2')
            .addClass('position-type-' + id);
    })

    $('.player').each(function () {
        let footballerId = $(this).attr('data-id');
        let positionId = $(this).attr('data-name');
        if (footballerId !== "undefined" && positionId !== "undefined") {
            $('#FootballersIdPositionsId').val($('#FootballersIdPositionsId').val() + footballerId + "-" + positionId + ",");
        }
    })

    $('body').on('dblclick', '.player', function (e) {
        let id = $(this).attr('data-id');
        let firstName = $(this).attr('data-first-name');
        let image = $(this).find('img').attr('src');
        let dataSide = $(this).attr('data-side');

        if (id == "undefined" || firstName == "undefined") return;

        let col = $('<div></div>').addClass('col-2 mb-3');
        let team = $('<div></div>')
            .addClass('teams team-1 text-center')
            .attr('data-id', id).attr('data-first-name', firstName);
        let img = $('<img>').attr('src', image).addClass('rounded-circle w-50');
        let h6 = $('<h6></h6>').text(firstName);

        let color1 = $('#Color1').val();
        let color2 = $('#Color2').val();

        team.append(img, h6);
        col.append(team);

        if (dataSide == 'home') {
            img.css(
                {
                    'border': '4px solid' + color1,
                })
            $('.team-1-area').append(col);
        }
        else if (dataSide == 'away') {
            img.css(
                {
                    'border': '4px solid' + color2,
                })
            $('.team-2-area').append(col);
        }

        // UPDATE DRAGGABLE
        $('.teams').draggable({ revert: true });

        $(this).find('img').attr('src', '');
        $(this).attr('data-id', 'undefined');
        $(this).attr('data-first-name', 'undefined');

        $('#FootballersIdPositionsId').val('');
        $('.player').each(function () {
            let footballerId = $(this).attr('data-id');
            let positionId = $(this).attr('data-name');
            if (footballerId !== "undefined" && positionId !== "undefined") {
                $('#FootballersIdPositionsId').val($('#FootballersIdPositionsId').val() + footballerId + "-" + positionId + ",");
            }
        })
    })

    let dataName1, dataName2, player1;
    $(document).on('click', '.player', function () {

        if ($('.player-1').length == 0) {

            if ($(this).attr('data-id') === "undefined") {
                return;
            }

            player1 = $(this);
            dataName1 = $(this).attr('data-name');

            $('.player').toggleClass('active');
            $(this).toggleClass('custom-border player-1');
        }
        else {

            player2 = $(this);
            dataName2 = $(this).attr('data-name');

            $(this).attr('data-name', dataName1);

            player1.attr('data-name', dataName2);

            $('.player-1').removeClass('player-1 custom-border');
            $('.player').removeClass('active');
        }

        $('#FootballersIdPositionsId').val('');
        $('.player').each(function () {
            let footballerId = $(this).attr('data-id');
            let positionId = $(this).attr('data-name');
            if (footballerId !== "undefined" && positionId !== "undefined") {
                $('#FootballersIdPositionsId').val($('#FootballersIdPositionsId').val() + footballerId + "-" + positionId + ",");
            }
        })

    })

    const btns = document.querySelectorAll('.team-color');

    if (btns !== null) {
        for (let btn of btns) {
            btn.addEventListener('click', function (e) {

                e.preventDefault();

                let container;

                if (this.classList.contains('team-color-1')) {
                    container = document.querySelector('.color-pickers-1');
                    const newElement = document.createElement('div');
                    container.appendChild(newElement);

                    const pickr = new Pickr({
                        el: newElement,
                        default: $('#Color1').val() || '#42445A',
                        theme: 'classic',
                        appClass: 'pcr-app-1',
                        swatches: [
                            'rgba(244, 67, 54, 1)',
                            'rgba(233, 30, 99, 0.95)',
                            'rgba(156, 39, 176, 0.9)',
                            'rgba(103, 58, 183, 0.85)',
                            'rgba(63, 81, 181, 0.8)',
                            'rgba(33, 150, 243, 0.75)',
                            'rgba(3, 169, 244, 0.7)',
                            'rgba(0, 188, 212, 0.7)',
                            'rgba(0, 150, 136, 0.75)',
                            'rgba(76, 175, 80, 0.8)',
                            'rgba(139, 195, 74, 0.85)',
                            'rgba(205, 220, 57, 0.9)',
                            'rgba(255, 235, 59, 0.95)',
                            'rgba(255, 193, 7, 1)'
                        ],

                        components: {
                            preview: true,
                            opacity: true,
                            hue: true,

                            interaction: {
                                hex: true,
                                rgba: true,
                                hsva: true,
                                input: true,
                                clear: true,
                                save: true
                            }
                        }
                    });

                    $(document).on('click', '.pcr-app-1 .pcr-save', function () {
                        let color1 = $('.pcr-app-1.visible').find('.pcr-result').val();
                        $('#Color1').val(color1);
                        $('.team-1 img').css(
                            {
                                'border': '4px solid' + color1,
                            })
                        $('.player[data-side="home"] .player__img').css(
                            {
                                'background': color1,
                                'border': '4px solid' + color1
                            });
                    })
                }
                else {
                    container = document.querySelector('.color-pickers-2');
                    const newElement = document.createElement('div');
                    container.appendChild(newElement);

                    const pickr = new Pickr({
                        el: newElement,
                        default: $('#Color2').val() || '#42445A',
                        theme: 'classic',
                        appClass: 'pcr-app-2',

                        swatches: [
                            'rgba(244, 67, 54, 1)',
                            'rgba(233, 30, 99, 0.95)',
                            'rgba(156, 39, 176, 0.9)',
                            'rgba(103, 58, 183, 0.85)',
                            'rgba(63, 81, 181, 0.8)',
                            'rgba(33, 150, 243, 0.75)',
                            'rgba(3, 169, 244, 0.7)',
                            'rgba(0, 188, 212, 0.7)',
                            'rgba(0, 150, 136, 0.75)',
                            'rgba(76, 175, 80, 0.8)',
                            'rgba(139, 195, 74, 0.85)',
                            'rgba(205, 220, 57, 0.9)',
                            'rgba(255, 235, 59, 0.95)',
                            'rgba(255, 193, 7, 1)'
                        ],

                        components: {
                            preview: true,
                            opacity: true,
                            hue: true,

                            interaction: {
                                hex: true,
                                rgba: true,
                                hsva: true,
                                input: true,
                                clear: true,
                                save: true
                            }
                        }
                    });
                    $(document).on('click', '.pcr-app-2 .pcr-save', function () {
                        let color2 = $('.pcr-app-2.visible').find('.pcr-result').val();
                        $('#Color2').val(color2);
                        $('.team-2 img').css(
                            {
                                'border': '4px solid' + color2,
                            })
                        $('.player[data-side="away"] .player__img').css(
                            {
                                'background': color2,
                                'border': '4px solid' + color2
                            });
                    })
                }

            });
        }
    }

    if ($('#Color1').val() !== "") {
        let color1 = $('#Color1').val();
        $('.team-1 img').css({ 'border': '4px solid' + color1 })
        $('.player[data-side="home"] .player__img').css(
            {
                'background': color1,
                'border': '4px solid' + color1
            });
    }

    if ($('#Color2').val() !== "") {
        let color2 = $('#Color2').val();
        $('.team-2 img').css({ 'border': '4px solid' + color2 });
        $('.player[data-side="away"] .player__img').css(
            {
                'background': color2,
                'border': '4px solid' + color2
            });
    }

    $(document).on('change', '#team-select', function () {
        let teamId = $(this).val();
        if (teamId) {
            $.ajax(
                {
                    url: "/Ajax/LoadFootballersByTeamId?TeamId=" + teamId,
                    type: "POST",
                    success: function (res) {
                        $(".team-area").hide();
                        $(".team-area").html(res).fadeIn();
                    },
                    error: function () {
                        swal("Xəta baş verdi !", {
                            icon: "error",
                        });
                    }
                })
        }
    })

    $(document).on('click', '.alert-team', function () {
        swal({
            content: {
                element: "select",
                attributes: {
                    name: "Team2Id",
                    className: "custom-select",
                    id: "team-select-2"
                },
            },
        }).then((value) => {
            let team2Id = $('#team-select-2').val();
            let price = $('#Price').val();
            if (value && footballerId && team1Id && price && team2Id) {
                let demo = new Object();
                demo.footballerId = footballerId;
                demo.team1Id = team1Id;
                demo.team2Id = team2Id;
                demo.price = price;

                if (demo != null) {
                    $.ajax(
                        {
                            url: "/Ajax/CreateTransfers",
                            type: "GET",
                            data: { demo: JSON.stringify(demo)},
                            datatype: 'json',
                            contentType: 'application/json; charset=utf-8',
                            success: function (res) {
                                $(".team-area").html(res);
                                swal("Successful !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        })
                }

                //swal(`Ok: ${teamId} ${team2Id} ${footballerId} ${price}`);
            }
            else {
                swal(`No change`);
            }
        });

        let swalContent = $('.swal-content');
        let input = $('<input>').addClass('form-control').attr('placeholder', "Price")
            .attr('name', 'Price').attr('id', 'Price');

        let labelTeam = $('<label></label>').text('Team').addClass('w-100 text-left');

        swalContent.prepend(labelTeam);
        swalContent.append(input);

        let labelPrice = $('<label></label>').text('Price').addClass('w-100 text-left mt-3');
        input.before(labelPrice);

        let footballerId = $(this).attr('data-id');
        let team1Id = $(this).attr('data-team-id');
        if (team1Id) {
            $.ajax(
                {
                    url: "/Ajax/LoadTeamsByTeamId?TeamId=" + team1Id,
                    type: "POST",
                    success: function (res) {
                        $("#team-select-2").html(res).prepend('<option disabled selected>Choose</option>');
                    },
                    error: function () {
                        swal("Xəta baş verdi !", {
                            icon: "error",
                        });
                    }
                })
        }

    })

    $(document).on('click', '#DeleteTransfer', function (e) {
        var TransferId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByTransferId?TransferId=" + TransferId,
                            type: "POST",
                            success: function (res) {
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

})