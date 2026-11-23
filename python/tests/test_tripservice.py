import sys
import os
import pytest

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

import tripservice


def test_user_not_logged_in(monkeypatch):
    user = tripservice.User()

    monkeypatch.setattr(tripservice, "_getLoggedUser", lambda: None)

    with pytest.raises(tripservice.UserNotLoggedInException):
        tripservice.getTripsByUser(user)


def test_friend_user_gets_trips(monkeypatch):
    user = tripservice.User()
    logged_user = tripservice.User()
    expected_trips = [tripservice.Trip()]

    monkeypatch.setattr(
        tripservice, "_getLoggedUser", lambda: logged_user
    )

    monkeypatch.setattr(
        user, "getFriends", lambda: [logged_user], raising=False
    )

    monkeypatch.setattr(
        tripservice, "_findTripsByUser", lambda user: expected_trips
    )

    result = tripservice.getTripsByUser(user)

    assert result == expected_trips



def test_non_friend_user_gets_empty_trips(monkeypatch):
    user = tripservice.User()
    logged_user = tripservice.User()
    another_friend = tripservice.User()

    monkeypatch.setattr(
        tripservice, "_getLoggedUser", lambda: logged_user
    )

    monkeypatch.setattr(
        user, "getFriends", lambda: [another_friend], raising=False
    )

    result = tripservice.getTripsByUser(user)

    assert result == []