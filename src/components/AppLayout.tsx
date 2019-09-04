import React, { FC } from "react"
import styled from "styled-components/macro"
import { Link } from "react-router-dom"

const Layout = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: stretch;
  align-items: stretch;
  height: 100vh;
`

const Title = styled.h1`
  flex-grow: 0;
  text-align: center;
  padding: 1em 0;
`

const Content = styled.main`
  flex: 1;
  padding-top: 5vh;
`

export const AppLayout: FC = props => {
  return (
    <Layout>
      <Title>
        <Link to="/">Turtl.io</Link>
      </Title>
      <Content>{props.children}</Content>
    </Layout>
  )
}
