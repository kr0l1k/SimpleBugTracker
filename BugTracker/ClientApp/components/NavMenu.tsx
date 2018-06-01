import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        //return <div className='main-nav'>
        //        <div className='navbar navbar-inverse'>
        //        <div className='navbar-header'>
        //            <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
        //                <span className='sr-only'>Toggle navigation</span>
        //                <span className='icon-bar'></span>
        //                <span className='icon-bar'></span>
        //                <span className='icon-bar'></span>
        //            </button>
        //            <Link className='navbar-brand' to={ '/' }>BugTracker</Link>
        //        </div>
        //        <div className='clearfix'></div>
        //        <div className='navbar-collapse collapse'>
        //            <ul className='nav navbar-nav'>
        //                <li>
        //                    <NavLink to={ '/' } exact activeClassName='active'>
        //                        <span className='glyphicon glyphicon-home'></span> Home
        //                    </NavLink>
        //                </li>
        //                <li>
        //                    <NavLink to={ '/counter' } activeClassName='active'>
        //                        <span className='glyphicon glyphicon-education'></span> Counter
        //                    </NavLink>
        //                </li>
        //                <li>
        //                    <NavLink to={ '/fetchdata' } activeClassName='active'>
        //                        <span className='glyphicon glyphicon-th-list'></span> Fetch data
        //                    </NavLink>
        //                </li>
        //            </ul>
        //        </div>
        //    </div>
        //</div>;
        return <div className='main-nav'>
            <ul className='nav navbar-nav'>
                <li> <NavLink to={'/addBug'} activeClassName='active'>
                                 New bug
                     </NavLink></li>
                <li><NavLink to={'/taskBoard'} activeClassName='active'>
                                 Task board
                     </NavLink></li>
                <li><a href="#news">Users</a></li>
                <li><a href="#logout">Log out</a></li>
            </ul>
        </div>;

    }
}
