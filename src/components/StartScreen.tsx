import React, { FC, useEffect } from "react"
import styled from "styled-components/macro"
import { Link } from "react-router-dom"
import { useDotNetify } from "use-dotnetify"

const Buttons = styled.div`
  display: flex;
  flex-direction: column;
  align-items: center;
  flex: 1;
  height: 100%;
  padding-top: 5vh;
`

const BaseButton = styled.button`
  height: 10vh;
  width: 70vw;
`

const JoinButton = styled(BaseButton)`
  background-color: lightgreen;
`

const CreateButton = styled(BaseButton)`
  margin-top: 5vh;
  background-color: lightblue;
`

const Game = (props: any) => {
  return (
    <>
      <div>{props.Id}</div>
      {props.Track.Turtles.map((x: any) => (
        <span key={x.Id} style={{ background: "light " + x.Color }}>
          {x.Id}
        </span>
      ))}
    </>
  )
}

export const StartScreen: FC<Props> = props => {
  const [state, vm] = useDotNetify("Turtl", { Games: [] })

  console.log(state)
  const createGame = () => {
    vm.$dispatch({ CreateGame: null })
  }

  return (
    <>
      {state.Games.map((x: any) => (
        <Game key={x.Id} {...x} />
      ))}
      <Buttons>
        <Link to="/join">
          <JoinButton>Join Game</JoinButton>
        </Link>

        <CreateButton onClick={createGame}>Create Game</CreateButton>
      </Buttons>
    </>
  )
}

interface Props {
  hasGames: boolean
}
