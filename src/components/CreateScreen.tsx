import React, { FC } from "react"
import { useDotNetify } from "use-dotnetify"
import styled from "styled-components/macro"

const Container = styled.div`
  display: flex;
  width: 100%;
  flex-direction: column;
  align-items: center;
`

const CreateButton = styled.button`
  height: 10vh;
  width: 70vw;
  background-color: lightblue;
`

// TODO: Deprecated
export const CreateScreen: FC = () => {
  const [state, vm] = useDotNetify("Turtl", { Games: {} })

  const createGame = () => {
    vm.$dispatch({ CreateGame: null })
  }

  return (
    <Container>
      <CreateButton onClick={createGame}>Create a game</CreateButton>
    </Container>
  )
}
