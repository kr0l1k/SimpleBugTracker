import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Board } from './components/TaskBoard';
import { BugCreater } from './components/BugCreate';

export const routes = <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/addBug' component={BugCreater} />
    <Route path='/taskBoard' component={Board} />
</Layout>;
