import React from "react"
import { BrowserRouter, Route, Redirect } from "react-router-dom"
import { DotNetifyProvider } from "use-dotnetify"
import {
  StartScreen,
  JoinScreen,
  CreateScreen,
  AppLayout,
  GameScreen,
  Providers,
} from "./"

export const App = () => {
  return (
    <Providers>
      <AppLayout>
        <Route path="/start" component={StartScreen} />
        <Route path="/join" component={JoinScreen} />
        <Route path="/create" component={CreateScreen} />
        <Route path="/game/:game" component={GameScreen} />
        <Route path="/" exact component={() => <Redirect to="/start" />} />
      </AppLayout>
    </Providers>
  )
}

export default App
