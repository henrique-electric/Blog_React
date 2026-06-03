import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'

import './App.css'
import MainPage from './mainPage'
import Topics from './Topicos'

function App() {
  const [currentPage, setCurrentPage] = useState('');
  const [showMainPage, setShowMainPage] = useState(true)
  const [showaboutMe, setShowAboutMe] = useState(false);
  const [showStart, setShowStart] = useState(false);
  const [showTopics, setShowTopics] = useState(false);

  const handleTab = (session) => {

      /*
        TODO
        - Optimize this logic, too tired now :(
      */
      switch (session) {
        case 'topics':
          setShowMainPage(false);
          setShowAboutMe(false);
          setShowTopics(true);
          break;
        
        case 'about':
          setShowMainPage(false);
          setShowTopics(false);
          setShowAboutMe(true);
          break;

        case 'main':
          setShowAboutMe(false);
          setShowTopics(false);
          setShowMainPage(true);
        default:
          break;
      }
  }

  return (
    <>
      <h1 className='mainTitle'>My interactive blog</h1>
      <div className='navContainer'>
        <button className='navBarBtn' onClick={() => handleTab('main')}>Inicio</button>
        <button className='navBarBtn' onClick={() => handleTab('topics')}>Tópicos</button>
        <button className="navBarBtn" onClick={() => handleTab('about')}>Sobre Mim</button>
      </div>

      {showMainPage && <MainPage/>}
      {showTopics && <Topics/>}
    </>
  )
}

export default App
