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

                if (dataId !== "undefined") {
                    let src = $(this).find('img').attr('src');
                    $(this).find('img').attr('src', draggableSrc).attr('data-id', footballerId);
                    ui.draggable.attr('data-id', dataId).find('img').attr('src', src);
                    ui.draggable.find('h6').text(dataFirstName);
                }
                else {
                    $(this).find('img').attr('src', ui.draggable.parent().remove().find('img').attr('src'));
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
    })

    $(document).on('click', '#team-1', function () {
        let psoitionType1Id = $('#PositionType1Id').val();
        let psoitionType2Id = $('#PositionType2Id').val();
        $('.team-1-area').fadeIn();
        $('.team-2-area').hide();
        $('.team').removeClass('position-type-' + psoitionType2Id).addClass('position-type-' + psoitionType1Id);

        $('.position-type-2-select').hide();
        $('.position-type-1-select').fadeIn();
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

        team.append(img, h6);
        col.append(team);

        if (dataSide == 'home') {
            $('.team-1-area').append(col);
        }
        else if (dataSide == 'away') {
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

    let id1, id2, src1, src2, firstName1, firstName2, player1;
    $(document).on('click', '.player', function () {

        if ($('.player-1').length == 0) {

            if ($(this).attr('data-id') === "undefined") {
                return;
            }

            player1 = $(this);
            id1 = $(this).attr('data-id');
            firstName1 = $(this).attr('data-first-name');
            src1 = $(this).find('img').attr('src');

            $('.player').toggleClass('active');
            $(this).toggleClass('custom-border player-1');
        }
        else {

            player2 = $(this);
            id2 = $(this).attr('data-id');
            firstName2 = $(this).attr('data-first-name');
            src2 = $(this).find('img').attr('src');

            $(this).attr('data-id', id1);
            $(this).attr('data-first-name', firstName1);
            $(this).find('img').attr('src', src1);

            player1.attr('data-id', id2);
            player1.attr('data-first-name', firstName2);
            player1.find('img').attr('src', src2);

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

})